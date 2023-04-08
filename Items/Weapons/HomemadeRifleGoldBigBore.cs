using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class HomemadeRifleGoldBigBore : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Homemade Elephant Gun");
			Tooltip.SetDefault("Upgraded with a big bore\nShoots a powerful, explosive bullet\n'Good for hunting demons, eldritch horrors, and elephants'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 50;
			Item.crit = 7;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 66;
			Item.height = 20;
			Item.useTime = 32;
			Item.useAnimation = 32;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 6;
			Item.rare = 3;
			Item.UseSound = SoundID.Item38;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.value = Item.buyPrice(silver: 50);
			Item.shootSpeed = 16f;
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
			if (type == ProjectileID.Bullet)
			{
				type = ProjectileID.ExplosiveBullet;
			}
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddIngredient(Mod.Find<ModItem>("HomemadeRifleGold").Type);
            recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}