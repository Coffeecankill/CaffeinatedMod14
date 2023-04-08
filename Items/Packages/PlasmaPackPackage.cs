using CaffinatedMod.Items.Weapons;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Packages
{
	public class PlasmaPackPackage : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Package");
			Tooltip.SetDefault("<right> to open\n'What's inside?'");
		}

		public override void SetDefaults() {
			Item.width = 10;
			Item.height = 10;
            Item.maxStack = 30;
            Item.rare = 1;
			Item.value = Item.buyPrice(gold: 15);
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot)
		{
			// Drop a special weapon/accessory etc. specific to this crate's theme (i.e. Sky Crate dropping Fledgling Wings or Starfury)
			int[] plasmaDrops = new int[] {
				ModContent.ItemType<Weapons.Disruptor>(),
				ModContent.ItemType<Weapons.Doom3Plasma>(),
				ModContent.ItemType<Weapons.DoomPlasma>()
			};
			itemLoot.Add(ItemDropRule.OneFromOptionsNotScalingWithLuck(1, plasmaDrops));
		}
	}
}