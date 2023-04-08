using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Placeable
{
	public class Radiator : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Radiator");
			Tooltip.SetDefault("Grants the Warmth buff in a radius");
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
			Item.createTile = TileType<Tiles.RadiatorTile>();
			Item.width = 32;
			Item.height = 32;
			Item.value = 1000;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
			.AddRecipeGroup("IronBar", 8)
			.AddIngredient(ItemID.WaterBucket, 1)
			.AddTile(TileID.Anvils)
			.Register();
		}
	}
}