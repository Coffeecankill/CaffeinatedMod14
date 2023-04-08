using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using CaffinatedMod.Items.Accessories.Tokens;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Packages
{
	public class TokenPackage : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Token Package");
			Tooltip.SetDefault("<right> to open\nContains a Blank Token.\nBlank Tokens can be used\nto make powerful accessories!");
		}

		public override void SetDefaults() {
			Item.width = 10;
			Item.height = 10;
            Item.maxStack = 30;
            Item.rare = 1;
			Item.value = Item.buyPrice(platinum: 1);
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot) {
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(ItemDropRule.NotScalingWithLuck(ModContent.ItemType<BlankToken>(), 1));
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.PlatinumCoin, 1);
			recipe.AddTile(null, "MysteriousMailboxTile");
			recipe.Register();
		}
	}
}