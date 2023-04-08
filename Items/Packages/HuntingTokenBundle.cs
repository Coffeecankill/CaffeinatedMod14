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
	public class HuntingTokenBundle : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Hunter's Token Bundle");
			Tooltip.SetDefault("<right> to unwrap\nIncludes a finch staff\nToken stats:\nIncreases your max number of minions by 2\n15% increased ranged damage");
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

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ModContent.ItemType<HunterToken>(), 1));
			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.BabyBirdStaff, 1));
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<BlankToken>(1)
				.AddIngredient(ItemID.Emerald, 1)
				.Register();
		}
	}
}