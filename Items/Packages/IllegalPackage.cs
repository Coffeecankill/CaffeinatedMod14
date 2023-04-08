/*
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Packages
{
	public class IllegalPackage : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Illegal Package");
			Tooltip.SetDefault("<right> to open\n'Don't tell noone!'");
		}

		public override void SetDefaults() {
			Item.width = 10;
			Item.height = 10;
            Item.maxStack = 30;
            Item.rare = 1;
			Item.value = Item.buyPrice(gold: 2);
		}

		public override bool CanRightClick() {
			return true;
		}
		
		public override void ModifyItemLoot(ItemLoot itemLoot) {
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.IllegalGunParts, 1));
		}
    }
}
*/
