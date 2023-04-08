using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Packages
{
	public class BrutePlasmaRiflePackage : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Package");
			Tooltip.SetDefault("<right> to open\n'What's inside?'");
		}

		public override void SetDefaults() {
			Item.width = 10;
			Item.height = 10;
            Item.maxStack = 30;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(gold: 6);
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot) {
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ModContent.ItemType<Weapons.BrutePlasmaRifle>(), 1));
		}
    }
}