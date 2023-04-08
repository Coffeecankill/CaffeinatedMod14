using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Letters
{
	public class SiltPackageInvoice : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Silt Package Invoice");
			Tooltip.SetDefault("Orders some silt for extracting\nDeposit this into the Mysterious Mailbox");
		}

		public override void SetDefaults() {
			Item.width = 22;
			Item.height = 12;
			Item.maxStack = 99;
			Item.rare = 1;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.value = Item.buyPrice(gold: 5);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldCoin, 5);
			recipe.AddIngredient(Mod.Find<ModItem>("StampedLetter").Type);
			recipe.AddTile(null, "MysteriousMailboxTile");
			recipe.Register();
		}
	}
}