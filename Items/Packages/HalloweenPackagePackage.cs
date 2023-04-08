using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Packages
{
	public class HalloweenPackagePackage : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Festive Package");
			Tooltip.SetDefault("<right> to open\n'Smells like Autumn!'");
		}

		public override void SetDefaults() {
			Item.width = 10;
			Item.height = 10;
            Item.maxStack = 30;
            Item.rare = 1;
			Item.value = Item.buyPrice(gold: 5);
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot) {
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.MagicalPumpkinSeed, 1));
			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.GoodieBag, 1));
		}
    }
}