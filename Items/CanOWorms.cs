using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items
{
	public class CanOWorms : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Can of Bait");
			Tooltip.SetDefault("<right> to open\n'Don't get caught fishing without it!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
		}

		public override void SetDefaults() {
			Item.width = 15;
			Item.height = 15;
            Item.maxStack = 99;
            Item.rare = 1;
			Item.value = Item.buyPrice(gold: 4);
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot) 
		{
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.Worm, 1, 10, 10));
		}

		public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.GoldCoin, 4);
            recipe.AddTile(null, "VendingMachineTile");
            recipe.Register();
			
			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldCoin, 3);
            recipe.AddTile(null, "VendingMachineTileV2");
            recipe.Register();
			
			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldCoin, 3);
            recipe.AddTile(null, "VendingMachineTileV3");
            recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldCoin, 2);
			recipe.AddTile(null, "VendingMachineTileV4");
			recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldCoin, 2);
			recipe.AddTile(null, "VendingMachineTileV5");
			recipe.Register();
		}
	}
}