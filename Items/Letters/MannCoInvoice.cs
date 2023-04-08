using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Letters
{
	public class MannCoInvoice : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Australium Invoice");
			Tooltip.SetDefault("Deposit this into the Mysterious Mailbox");
		}

		public override void SetDefaults() {
			Item.width = 22;
			Item.height = 12;
            Item.maxStack = 30;
            Item.rare = 1;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.value = Item.buyPrice(gold: 15);
		}
		public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.GoldBar, 99);
			recipe.AddTile(null, "VendingMachineTileV2");
            recipe.Register();
			
			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.PlatinumBar, 99);
			recipe.AddTile(null, "VendingMachineTileV2");
            recipe.Register();
		}
    }
}