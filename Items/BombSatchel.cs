using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items
{
	public class BombSatchel : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Bomb Satchel");
			Tooltip.SetDefault("<right> to open\n'What makes me a good demoman?'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
		}

		public override void SetDefaults() {
			Item.width = 10;
			Item.height = 10;
            Item.maxStack = 99;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(silver: 45);
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot) {
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.Bomb, 1, 16, 16));
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverCoin, 45);
			recipe.AddTile(null, "VendingMachineTileV2");
			recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverCoin, 32);
			recipe.AddTile(null, "VendingMachineTileV3");
			recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverCoin, 27);
			recipe.AddTile(null, "VendingMachineTileV4");
			recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverCoin, 22);
			recipe.AddTile(null, "VendingMachineTileV5");
			recipe.Register();
		}
	}
}