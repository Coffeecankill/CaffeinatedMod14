using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using CaffinatedMod.Projectiles;
using Terraria.GameContent.Creative;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class Vlad1k : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Vlad-1000");
			Tooltip.SetDefault("Fires a spread of nails\nBenefits from melee modifiers\n'Military grade nailgun'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 20;
			Item.DamageType = DamageClass.Melee;
			Item.width = 62;
			Item.height = 34;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 3;
			Item.rare = 4;
			Item.autoReuse = false;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 20);
			Item.shootSpeed = 12f;
			//Item.shoot = ProjectileID.MeteorShot;
			Item.shoot = ProjectileType<Nail2>();
			Item.useAmmo = AmmoID.Bullet;
			if (!Main.dedServ)
				Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/Vlad");
		}

		public override Vector2? HoldoutOffset()
        {
            return new Vector2(-14, 6);
        }

		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			//type = ProjectileID.MeteorShot;
			type = ProjectileType<Nail2>();
			int numberProjectiles = 4 + Main.rand.Next(0);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = velocity.RotatedByRandom(MathHelper.ToRadians(4));
				float scale = 1f - (Main.rand.NextFloat() * .2f);
				perturbedSpeed = perturbedSpeed * scale;
				Projectile.NewProjectile(source, position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
			}
			return false;
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.GoldCoin, 14);
            recipe.AddTile(null, "VendingMachineTileV3");
            recipe.Register();
		}
	}
}