using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Placeable
{
	public class Oven : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Oven");
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
			Item.createTile = TileType<Tiles.OvenTile>();
			Item.width = 32;
			Item.height = 34;
			Item.value = 3000;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
			.AddRecipeGroup("IronBar", 8)
			.AddRecipeGroup("CopperBars", 3)
			.AddIngredient(ItemID.Glass, 4)
			.AddTile(TileID.Anvils)
			.Register();

		}
	}
}