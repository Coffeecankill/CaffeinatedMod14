using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items
{
	public class GrenadeSatchel : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Grenade Satchel");
			Tooltip.SetDefault("<right> to open\n'Send them to their doom with a nice big boom!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
		}

		public override void SetDefaults() {
			Item.width = 10;
			Item.height = 10;
			Item.maxStack = 99;
			Item.rare = 1;
			Item.value = Item.buyPrice(silver: 24);
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot) {
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.Grenade, 1, 32, 32));
		}

		public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SilverCoin, 19);
            recipe.AddTile(null, "VendingMachineTileV2");
            recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverCoin, 17);
			recipe.AddTile(null, "VendingMachineTileV3");
			recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverCoin, 14);
			recipe.AddTile(null, "VendingMachineTileV4");
			recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverCoin, 12);
			recipe.AddTile(null, "VendingMachineTileV5");
			recipe.Register();
		}
    }
}