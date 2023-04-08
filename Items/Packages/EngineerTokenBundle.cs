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
	public class EngineerTokenBundle : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Engineer Token Bundle");
			Tooltip.SetDefault("<right> to unwrap\nIncludes a flamethrower sentry\nToken stats:\n6 defense\nIncreases your max number of sentries by 1");
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

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ModContent.ItemType<EngineerToken>(), 1));
			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ModContent.ItemType<ETurretItem>(), 1));
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<BlankToken>(1)
				.AddIngredient(ItemID.Ruby, 1)
				.AddIngredient(ItemID.Topaz, 1)
				.Register();
		}
	}
}