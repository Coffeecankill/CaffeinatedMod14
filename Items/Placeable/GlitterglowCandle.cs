using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Placeable
{
	public class GlitterglowCandle : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Glitterglow Candle");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		
		public override void SetDefaults() {
			Item.useStyle = 1;
			Item.useTurn = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.autoReuse = true;
			Item.maxStack = 99;
			Item.rare = ItemRarityID.White;
			Item.consumable = true;
			Item.createTile = TileType<Tiles.GlitterglowCandleTile>();
			Item.width = 16;
			Item.height = 18;
			Item.value = 1000;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemType<Glitterglow>(), 1)
				.AddRecipeGroup("CopperBars", 1)
				.AddRecipeGroup("Wood", 4)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}