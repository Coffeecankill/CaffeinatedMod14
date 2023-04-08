using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class HomemadeRifleGold : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Homemade Rifle");
			Tooltip.SetDefault("Can be upgraded\n'Crude but effective!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 25;
			Item.crit = 7;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 66;
			Item.height = 20;
			Item.useTime = 36;
			Item.useAnimation = 36;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 4;
			Item.rare = 1;
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.value = Item.buyPrice(silver: 50);
			Item.shootSpeed = 12f;
			Item.useAmmo = AmmoID.Bullet;
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-6, 0);
        }
				
        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback) {
	        Vector2 muzzleOffset = Vector2.Normalize(velocity) * 25f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, -5, 0))
			{
				position += muzzleOffset;
			}
		}

        public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddRecipeGroup("Wood", 10);
			recipe.AddRecipeGroup("IronBar", 15);
			recipe.AddIngredient(ItemID.MusketBall, 1);
			recipe.AddIngredient(ItemID.GoldBar, 3);
            recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}