using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Packages
{
	public class XmasPackagePackage : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Festive Package");
			Tooltip.SetDefault("<right> to open\n'Smells like peppermint!'");
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

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.YellowPresent));
			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.YellowPresent));
			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.BluePresent));
			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.BluePresent));
			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.GreenPresent));
			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.GreenPresent));
		}
	}
}