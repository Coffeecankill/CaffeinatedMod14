using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Placeable
{
	public class VendingMachineV3 : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Vending Machine Mk.III");
			Tooltip.SetDefault("'New and improved!'\n30% discount granted\nStocked by Volt Industries");
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
			Item.rare = ItemRarityID.Orange;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.value = 40000;
			Item.createTile = TileType<Tiles.VendingMachineTileV3>();
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.PixieDust, 15)
				.AddIngredient(ItemID.FallenStar, 1)
				.AddIngredient(null, "VendingMachine")
				.AddTile(TileID.Anvils)
				.Register();

			CreateRecipe()
				.AddIngredient(ItemID.PixieDust, 15)
				.AddIngredient(ItemID.FallenStar, 1)
				.AddIngredient(null, "VendingMachineV2")
				.AddTile(TileID.Anvils)
				.Register();

			CreateRecipe()
				.AddIngredient(ItemID.PixieDust, 25)
				.AddRecipeGroup("CopperBars", 4)
				.AddIngredient(ItemID.Glass, 5)
				.AddIngredient(ItemID.FallenStar, 1)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}