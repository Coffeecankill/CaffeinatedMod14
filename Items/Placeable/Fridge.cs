using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Placeable
{
	public class Fridge : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Refrigerator");
			Tooltip.SetDefault("<right> to become well fed\n'The fridge judges you\nas you raid it's contents!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 44;
			Item.height = 64;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.rare = ItemRarityID.Blue;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.createTile = TileType<Tiles.FridgeTile>();
			Item.value = 10000;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddRecipeGroup("CopperBars", 5)
				.AddRecipeGroup("IronBar", 12)
				.AddIngredient(ItemID.CookedFish, 20)
				.AddIngredient(ItemID.FrozenSlimeBlock, 5)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}