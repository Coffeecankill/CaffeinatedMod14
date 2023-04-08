using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Placeable
{
	public class Pinkward : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Vision Ward");
			Tooltip.SetDefault("Provides light and \nshows enemy locations");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
		}
		
		public override void SetDefaults() {
			Item.useStyle = 1;
			Item.useTurn = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.autoReuse = true;
			Item.maxStack = 99;
			Item.rare = ItemRarityID.Blue;
			Item.consumable = true;
			Item.createTile = TileType<Tiles.PinkwardTile>();
			Item.width = 16;
			Item.height = 34;
			Item.value = 500;
		}
	}
}