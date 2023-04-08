using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Placeable
{
	public class Telephone : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Tele-phone");
			Tooltip.SetDefault("<right> to teleport home");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
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
			Item.createTile = TileType<Tiles.TelephoneTile>();
			Item.width = 16;
			Item.height = 18;
			Item.value = 1000;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
			.AddRecipeGroup("IronBar", 4)
			.AddRecipeGroup("CopperBars", 1)
			.AddIngredient(ItemID.FallenStar, 1)
			.AddTile(TileID.Anvils)
			.Register();
		}
	}
}