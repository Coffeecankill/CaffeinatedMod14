using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using CaffinatedMod.Projectiles;
using CaffinatedMod.Items.Accessories.Tokens;
using CaffinatedMod.Items;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Packages
{
	public class TreasureTokenBundle : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Treasure Hunting Token Bundle");
			Tooltip.SetDefault("<right> to unwrap\nIncludes a Magic Lantern\nToken stats:\nShows position\nDisplays valuables around you");
		}

		public override void SetDefaults() {
			Item.width = 10;
			Item.height = 10;
            Item.maxStack = 30;
            Item.rare = 1;
			Item.value = Item.buyPrice(gold: 1);
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot)
		{
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ModContent.ItemType<TreasureToken>(), 1));
			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.MagicLantern, 1));
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<BlankToken>(1)
				.AddIngredient(ItemID.Diamond, 1)
				.AddRecipeGroup("GoldBars", 3)
				.Register();
		}
	}
}