using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Placeable
{
	public class VendingMachine : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Vending Machine");
			Tooltip.SetDefault("'Convenience for coin!'\nStocked by Volt Industries");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 44;
			Item.height = 64;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.rare = ItemRarityID.Blue;
			Item.value = 10000;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.createTile = TileType<Tiles.VendingMachineTile>();
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddRecipeGroup("IronBar", 15)
				.AddRecipeGroup("CopperBars", 4)
				.AddIngredient(ItemID.Glass, 5)
				.AddIngredient(ItemID.FallenStar, 1)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}