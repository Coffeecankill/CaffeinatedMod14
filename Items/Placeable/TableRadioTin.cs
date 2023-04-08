using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using CaffinatedMod.Items.Tiles;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Placeable
{
	public class TableRadioTin : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Jazzy Radio");
			Tooltip.SetDefault("Grants the Happy buff in a radius\n'Smooth jazz all day baby!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
			MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Music/MysteriousBroadcast2"), ModContent.ItemType<TableRadioTin>(), ModContent.TileType<TableRadioTinTile>());
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
			Item.createTile = TileType<Tiles.TableRadioTinTile>();
			Item.width = 28;
			Item.height = 20;
			Item.value = 1000;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
			.AddRecipeGroup("Wood", 10)
			.AddRecipeGroup("CopperBars", 3)
			.AddIngredient(ItemID.TinWatch, 1)
			.AddTile(TileID.WorkBenches)
			.Register();
		}
	}
}