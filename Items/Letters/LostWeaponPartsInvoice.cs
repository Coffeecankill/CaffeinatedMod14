/*
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Letters
{
	public class LostWeaponPartsInvoice : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Lost weapon parts Invoice");
			Tooltip.SetDefault("'What a strange letter...'\nDeposit this into the Mysterious Mailbox");
		}

		public override void SetDefaults() {
			Item.width = 22;
			Item.height = 12;
            Item.maxStack = 30;
            Item.rare = 1;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.value = Item.buyPrice(gold: 2);
		}

		public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.GoldCoin, 20);
            recipe.AddTile(null, "VendingMachineTileV2");
            recipe.Register();

        }
    }
}
*/
