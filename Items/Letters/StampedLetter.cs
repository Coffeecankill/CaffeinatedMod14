using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Letters
{
	public class StampedLetter : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Stamped Letter");
			Tooltip.SetDefault("Can be combined with \nitems to make invoices");
		}

		public override void SetDefaults() {
			Item.width = 22;
			Item.height = 12;
			Item.maxStack = 99;
			Item.rare = 1;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.value = Item.buyPrice(silver: 30);
		}
		
		public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SilverCoin, 20);
            recipe.AddTile(null, "MysteriousMailboxTile");
            recipe.Register();
        }
    }
}