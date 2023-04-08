using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Placeable
{
	public class Glitterglow : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Glitterglow");
			Tooltip.SetDefault("'Magical light glows from inside!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
		}
		
		public override void SetDefaults() {
			Item.useStyle = 1;
			Item.useTurn = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.autoReuse = true;
			Item.maxStack = 999;
			Item.rare = ItemRarityID.Blue;
			Item.consumable = true;
			Item.createTile = TileType<Tiles.GlitterglowTile>();
			Item.width = 16;
			Item.height = 16;
			Item.value = 100;
		}

		public override void AddRecipes()
		{
			CreateRecipe(15)
				.AddIngredient(ItemID.FallenStar, 1)
				.AddIngredient(ItemID.StoneBlock, 10)
				.AddTile(TileID.Furnaces)
				.Register();
		}
	}
}