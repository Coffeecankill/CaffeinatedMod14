using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Letters
{
	public class AR2Invoice : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Peculiar Invoice");
			Tooltip.SetDefault("Orders a pulse rifle from\nan alternate dimension, deposit\nthis into the Mysterious Mailbox");
		}

		public override void SetDefaults() {
			Item.width = 25;
			Item.height = 12;
            Item.maxStack = 30;
            Item.rare = 1;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.value = Item.buyPrice(gold: 20);
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldCoin, 20);
			recipe.AddTile(null, "VendingMachineTileV5");
			recipe.Register();
		}
	}
}