/*
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Letters
{
	public class BugNetInvoice : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bug Net Invoice");
			Tooltip.SetDefault("Deposit this into the Mysterious Mailbox");
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
			Item.value = Item.buyPrice(silver: 25);
		}
		/*
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.SilverCoin, 25)
				.AddIngredient(Mod, "StampedLetter")
				.AddTile(TileID.Tables)
				.Register();
		} 
	}
}
*/