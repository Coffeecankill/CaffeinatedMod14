using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using CaffinatedMod.Projectiles;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class TriBeam : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tri-Beam AER9");
			Tooltip.SetDefault("'Surely a voided warranty'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 50;
			Item.height = 20;
			Item.damage = 120;
			Item.DamageType = DamageClass.Magic;
			Item.shoot = ProjectileType<RedLaser>();
			Item.channel = true;
			Item.mana = 25;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.knockBack = 1;
			Item.autoReuse = false;
			Item.rare = 7;
			Item.value = Item.buyPrice(gold: 35);
			Item.shootSpeed = 16f;
			if (!Main.dedServ)
				Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/WazerWifle");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-11, 2);
		}

		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			type = ProjectileType<RedLaser>();
			int numberProjectiles = 3 + Main.rand.Next(0);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = velocity.RotatedByRandom(MathHelper.ToRadians(3));
				Projectile.NewProjectile(source, position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
			}
			return false;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IllegalGunParts, 3);
			recipe.AddIngredient(Mod.Find<ModItem>("AER9").Type);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}