using Terraria;
using Terraria.GameContent.Creative;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items
{
	public class BundleOfArrows : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pack of Arrows");
			Tooltip.SetDefault("<right> to open\n'Perfect for all current and ex-adventurers!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
		}

		public override void SetDefaults()
		{
			Item.width = 10;
			Item.height = 10;
			Item.maxStack = 99;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(silver: 10);
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot) 
		{
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.WoodenArrow, 1, 200, 200));
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