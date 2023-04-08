using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items
{
	public class CanOfRope : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Rope Canister");
			Tooltip.SetDefault("<right> to open\n'You'll bawl if you take a fall!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
		}

		public override void SetDefaults() {
			Item.width = 15;
			Item.height = 15;
            Item.maxStack = 99;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(silver: 10);
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot) {
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.Rope, 1, 100, 100));
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.SilverCoin, 10)
				.AddTile(null, "VendingMachineTile")
				.Register();

			CreateRecipe()
				.AddIngredient(ItemID.SilverCoin, 8)
				.AddTile(null, "VendingMachineTileV2")
				.Register();

			CreateRecipe()
				.AddIngredient(ItemID.SilverCoin, 7)
				.AddTile(null, "VendingMachineTileV3")
				.Register();

			CreateRecipe()
				.AddIngredient(ItemID.SilverCoin, 6)
				.AddTile(null, "VendingMachineTileV4")
				.Register();

			CreateRecipe()
				.AddIngredient(ItemID.SilverCoin, 5)
				.AddTile(null, "VendingMachineTileV5")
				.Register();
		}
	}
}