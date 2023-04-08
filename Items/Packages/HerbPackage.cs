using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Packages
{
	public class HerbPackage : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Planting Kit");
			Tooltip.SetDefault("<right> to open\n'Make the world\na greener place!'");
		}

		public override void SetDefaults() {
			Item.width = 10;
			Item.height = 10;
			Item.maxStack = 99;
			Item.rare = 1;
			Item.value = Item.buyPrice(gold: 1);
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot) {
			base.ModifyItemLoot(itemLoot);
			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.Acorn, 1, 10, 10));
			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.PumpkinSeed, 1, 15, 15));
			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.ClayPot, 1, 10, 10));
			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.HerbBag, 1, 1, 1));
		}
		
		public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SilverCoin, 35);
            recipe.AddTile(null, "VendingMachineTile");
            recipe.Register();
			
			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverCoin, 28);
            recipe.AddTile(null, "VendingMachineTileV2");
            recipe.Register();
			
			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverCoin, 24);
            recipe.AddTile(null, "VendingMachineTileV3");
            recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverCoin, 21);
			recipe.AddTile(null, "VendingMachineTileV4");
			recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverCoin, 17);
			recipe.AddTile(null, "VendingMachineTileV5");
			recipe.Register();
		}
    }
}