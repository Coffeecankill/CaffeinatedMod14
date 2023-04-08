using CaffinatedMod.Items.Weapons;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Packages
{
	public class OWPackage : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Package");
			Tooltip.SetDefault("<right> to open\n'What's inside?'");
		}

		public override void SetDefaults()
		{
			Item.width = 10;
			Item.height = 10;
			Item.maxStack = 30;
			Item.rare = 1;
			Item.value = Item.buyPrice(gold: 5);
		}

		public override bool CanRightClick()
		{
			return true;
		}
		/*
		public override void ModifyItemLoot(ItemLoot itemLoot) {
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ModContent.ItemType<OWFragLauncher>()));
		}
		*/
		public override void ModifyItemLoot(ItemLoot itemLoot)
		{
			// Drop a special weapon/accessory etc. specific to this crate's theme (i.e. Sky Crate dropping Fledgling Wings or Starfury)
			int[] themedDrops = new int[] {
				ModContent.ItemType<Weapons.Trailblazer>(),
				ModContent.ItemType<Weapons.OWFragLauncher>(),
				ModContent.ItemType<Weapons.BioshockLauncher>()
			};
			itemLoot.Add(ItemDropRule.OneFromOptionsNotScalingWithLuck(1, themedDrops));
		}
	}
}