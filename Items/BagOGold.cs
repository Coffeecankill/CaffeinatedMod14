using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items
{
	public class BagOGold : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Sly Sack of Silver");
			Tooltip.SetDefault("<right> to open");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
		}

		public override void SetDefaults() {
			Item.width = 10;
			Item.height = 10;
			Item.maxStack = 999;
			Item.rare = 3;
			Item.value = Item.buyPrice(silver: 50);
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot) {
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.SilverCoin, 1, 7, 20));
		}
    }
}