/*
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Placeable
{
	public class PoolTable : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pool Table");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 44;
			Item.height = 64;
			Item.maxStack = 30;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.rare = ItemRarityID.Blue;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.createTile = TileType<Tiles.PoolTableTile>();
			Item.value = 2000;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddRecipeGroup("Wood", 20)
				.AddIngredient(ItemID.Silk, 10)
				.AddTile(TileID.HeavyWorkBench)
				.Register();
		}
	}
}
*/