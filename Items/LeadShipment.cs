using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items
{
	public class LeadShipment : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Lead Shipment");
			Tooltip.SetDefault("<right> to open");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
		}

		public override void SetDefaults() {
			Item.width = 12;
			Item.height = 22;
            Item.maxStack = 99;
            Item.rare = ItemRarityID.White;
			Item.value = Item.buyPrice(silver: 135);
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot) {
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.LeadOre, 1, 90, 90));
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.GoldCoin, 1)
				.AddIngredient(ItemID.SilverCoin, 35)
				.AddTile(null, "OrePneumoTile")
				.Register();
		}
	}
}