using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Letters
{
	public class BrutePlasmaRifleInvoice : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Peculiar Invoice");
			Tooltip.SetDefault("Orders a plasma rifle from an\nalternate dimension, deposit\nthis into the Mysterious Mailbox");
		}

		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 12;
			Item.maxStack = 30;
			Item.rare = ItemRarityID.Blue;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.value = Item.buyPrice(gold: 15);
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.GoldCoin, 15)
				.AddTile(null, "VendingMachineTileV3")
				.Register();
		}
	}
}