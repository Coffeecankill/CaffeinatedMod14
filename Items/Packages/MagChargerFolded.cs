using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Packages
{
	public class MagChargerFolded : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Folded Magcharger");
			Tooltip.SetDefault("<right> to open\n'Compact Railgun'\nCan pierce blocks");
		}

		public override void SetDefaults() {
			Item.width = 10;
			Item.height = 10;
            Item.maxStack = 30;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(gold: 24);
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot) {
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ModContent.ItemType<Weapons.MagCharger>(), 1));
		}
		/*
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldCoin, 25);
            recipe.AddTile(null, "VendingMachineTileV3");
            recipe.Register();
		}
		*/
	}
}