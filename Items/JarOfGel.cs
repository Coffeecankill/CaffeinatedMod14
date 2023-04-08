using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items
{
	public class JarOfGel : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Jar of Gel");
			Tooltip.SetDefault("<right> to open\n'Full of gel and has a sweet smell!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
		}

		public override void SetDefaults() {
			Item.width = 15;
			Item.height = 15;
            Item.maxStack = 99;
            Item.rare = 1;
			Item.value = Item.buyPrice(silver: 50);
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot) {
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.Gel, 1, 50, 50));
		}

		public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SilverCoin, 50);
            recipe.AddTile(null, "VendingMachineTile");
            recipe.Register();
			
			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverCoin, 40);
            recipe.AddTile(null, "VendingMachineTileV2");
            recipe.Register();
			
			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverCoin, 35);
            recipe.AddTile(null, "VendingMachineTileV3");
            recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverCoin, 30);
			recipe.AddTile(null, "VendingMachineTileV4");
			recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverCoin, 25);
			recipe.AddTile(null, "VendingMachineTileV5");
			recipe.Register();
		}
    }
}