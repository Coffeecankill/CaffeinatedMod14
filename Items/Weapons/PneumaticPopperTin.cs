using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class PneumaticPopperTin : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Pneumatic Popper");
			Tooltip.SetDefault("Allows the collection of seeds for ammo");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 5;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 52;
			Item.height = 16;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 1;
			Item.rare = 1;
			Item.UseSound = SoundID.Item108;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 1);
			Item.shootSpeed = 14f;
			Item.useAmmo = AmmoID.Dart;
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-4, 4);
        }
		
		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			int numberProjectiles = 1 + Main.rand.Next(3);
			for (int i = 0; i < numberProjectiles; i++)
			{
                type = ProjectileID.Seed;
				
				Vector2 perturbedSpeed = velocity.RotatedByRandom(MathHelper.ToRadians(05));
				float scale = 1f - (Main.rand.NextFloat() * .2f);
				perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(source, position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
			}
			return false;
		}
		
        public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddRecipeGroup("Wood", 10);
			recipe.AddRecipeGroup("IronBar", 5);
			recipe.AddIngredient(ItemID.TinBar, 5);
			recipe.AddIngredient(ItemID.Blowpipe, 1);
            recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}