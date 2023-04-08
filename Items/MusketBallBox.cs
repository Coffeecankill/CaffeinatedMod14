using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items
{
	public class MusketBallBox : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Box of Musket Balls");
			Tooltip.SetDefault("<right> to open\n'Guns are magic and this is your mana!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
		}

		public override void SetDefaults() {
			Item.width = 10;
			Item.height = 10;
			Item.maxStack = 99;
			Item.rare = 1;
			Item.value = Item.buyPrice(silver: 14);
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot) {
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.MusketBall, 1, 200, 200));
		}

		public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SilverCoin, 11);
            recipe.AddTile(null, "VendingMachineTileV2");
            recipe.Register();
			
			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverCoin, 10);
            recipe.AddTile(null, "VendingMachineTileV3");
            recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverCoin, 8);
			recipe.AddTile(null, "VendingMachineTileV4");
			recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverCoin, 7);
			recipe.AddTile(null, "VendingMachineTileV5");
			recipe.Register();
		}
    }
}