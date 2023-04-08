using CaffinatedMod.Items.Weapons;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Packages
{
	public class MannCoPackage : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Mann Co. Package");
			Tooltip.SetDefault("<right> to open\n'We sell products and get in fights'");
		}

		public override void SetDefaults() {
			Item.width = 10;
			Item.height = 10;
            Item.maxStack = 30;
            Item.rare = 3;
			Item.value = Item.buyPrice(gold: 40);
		}

		public override bool CanRightClick() {
			return true;
		}
		
		public override void ModifyItemLoot(ItemLoot itemLoot) {
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ModContent.ItemType<PanicAttack>()));
			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ModContent.ItemType<VolcanoFragment>()));
			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ModContent.ItemType<Blutsauger>()));
		}
	}
}