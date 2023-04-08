using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class Tootba : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Tooty Tuba");
			Tooltip.SetDefault("Fires a massive spread of bullets");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 20;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 52;
			Item.height = 34;
			Item.useTime = 50;
			Item.useAnimation = 50;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 5;
			Item.rare = 4;
			Item.autoReuse = false;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 18);
			Item.shootSpeed = 7f;
			Item.useAmmo = AmmoID.Bullet;
			if (!Main.dedServ) {
				Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/Toot")
				{
					PitchVariance = .30f
				};
			}
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-3, 6);
        }
		
		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			Vector2 muzzleOffset = Vector2.Normalize(velocity) * 35f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			int numberProjectiles = 26 + Main.rand.Next(0);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = velocity.RotatedByRandom(MathHelper.ToRadians(50));
				float scale = 1f - (Main.rand.NextFloat() * .3f);
				perturbedSpeed = perturbedSpeed * scale;
				Projectile.NewProjectile(source, position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
			}
			return false;
		}
		/*
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<DreamBar>(5)
				.AddIngredient(ItemID.HallowedBar, 10)
				.AddTile<Tiles.TelevisionTile>()
				.Register();
		}
		*/
	}
}