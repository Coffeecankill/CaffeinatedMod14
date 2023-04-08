using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Placeable
{
	public class VendingMachineV2 : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Vending Machine Mk.II");
			Tooltip.SetDefault("'Munitions for the mission!'\n20% discount granted\nStocked by Volt Industries");
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
			Item.rare = ItemRarityID.Green;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.value = 10000;
			Item.createTile = TileType<Tiles.VendingMachineTileV2>();
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.MeteoriteBar, 10)
				.AddIngredient(ItemID.FallenStar, 1)
				.AddIngredient(null, "VendingMachine")
				.AddTile(TileID.Anvils)
				.Register();

			CreateRecipe()
				.AddIngredient(ItemID.MeteoriteBar, 20)
				.AddRecipeGroup("CopperBars", 4)
				.AddIngredient(ItemID.Glass, 5)
				.AddIngredient(ItemID.FallenStar, 1)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}