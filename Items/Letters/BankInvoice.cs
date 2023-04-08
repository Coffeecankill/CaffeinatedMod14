/*
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Letters
{
	public class BankInvoice : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Urgent Invoice");
			Tooltip.SetDefault("Deposit this into the Mysterious Mailbox");
		}

		public override void SetDefaults() {
			Item.width = 22;
			Item.height = 12;
			Item.maxStack = 30;
			Item.rare = ItemRarityID.Blue;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.value = Item.buyPrice(gold: 2);
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.GoldCoin, 1)
				.AddIngredient(Mod, "StampedLetter")
				.AddTile(TileID.Tables)
				.Register();
		}
		
	}
}
*/