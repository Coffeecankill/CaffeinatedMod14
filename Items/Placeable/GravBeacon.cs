using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Placeable
{
	public class GravBeacon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gravity Pylon");
			Tooltip.SetDefault("Lowers gravity when placed nearby");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 46;
			Item.height = 76;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.rare = 3;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.createTile = TileType<Tiles.GravBeaconTile>();
			Item.value = 10000;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
			.AddIngredient(ItemID.Glass, 15)
			.AddIngredient(ItemID.MeteoriteBar, 15)
			.AddRecipeGroup("IronBar", 15)
			.AddRecipeGroup("CopperBars", 5)
			.AddTile(TileID.Anvils)
			.Register();
		}
	}
}