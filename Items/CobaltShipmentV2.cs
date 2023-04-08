using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items
{
	public class CobaltShipmentV2 : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Cobalt Shipment");
			Tooltip.SetDefault("<right> to open");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
		}

		public override void SetDefaults() {
			Item.width = 12;
			Item.height = 22;
            Item.maxStack = 99;
			Item.rare = ItemRarityID.Orange;
			Item.value = Item.buyPrice(gold: 6);
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot) {
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.CobaltOre, 1, 90, 90));
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.GoldCoin, 6)
				.AddIngredient(ItemID.SilverCoin, 30)
				.AddTile(null, "OrePneumoV2Tile")
				.Register();
		}
	}
}