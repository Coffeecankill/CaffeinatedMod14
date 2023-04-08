/*
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items
{
	public class BagOfSeeds : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Seed Pouch");
			Tooltip.SetDefault("<right> to open\n'The hardest seeds from overseas!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
		}

		public override void SetDefaults() {
			Item.width = 15;
			Item.height = 15;
            Item.maxStack = 99;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(copper: 50);
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot) {
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.Seed, 1, 35, 35));
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.CopperCoin, 50)
				.AddTile(null, "VendingMachineTile")
				.Register();

			CreateRecipe()
				.AddIngredient(ItemID.CopperCoin, 40)
				.AddTile(null, "VendingMachineTileV2")
				.Register();

			CreateRecipe()
				.AddIngredient(ItemID.CopperCoin, 35)
				.AddTile(null, "VendingMachineTileV3")
				.Register();
		} 
	}
}
*/