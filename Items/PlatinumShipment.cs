using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items
{
	public class PlatinumShipment : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Platinum Shipment");
			Tooltip.SetDefault("<right> to open");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
		}

		public override void SetDefaults() {
			Item.width = 12;
			Item.height = 22;
            Item.maxStack = 99;
            Item.rare = ItemRarityID.Green;
			Item.value = Item.buyPrice(silver: 540);
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot) {
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.PlatinumOre, 1, 120, 120));
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.GoldCoin, 5)
				.AddIngredient(ItemID.SilverCoin, 40)
				.AddTile(null, "OrePneumoTile")
				.Register();
		}
	}
}