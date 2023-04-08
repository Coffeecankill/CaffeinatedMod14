using Microsoft.Xna.Framework;
using Terraria.GameContent.Creative;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class BlackJackFlareGun : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Blackjack Flaregun");
			Tooltip.SetDefault("'Hudda hudda huh!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 29;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 45;
			Item.height = 22;
			Item.useTime = 40;
			Item.useAnimation = 40;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 2;
			Item.rare = 1;
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 2);
			Item.shootSpeed = 16f;
			Item.useAmmo = AmmoID.Flare;
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(3, 0);
        }

        public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.FlareGun, 1);
            recipe.AddRecipeGroup("IronBar", 10);
			recipe.AddRecipeGroup("Wood", 5);
            recipe.AddIngredient(ItemID.Topaz, 5);
            recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}