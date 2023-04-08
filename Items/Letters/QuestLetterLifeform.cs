using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Letters
{
	public class QuestLetterLifeform : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Quest Letter: Lifeform Analyzer");
			Tooltip.SetDefault("'Greetings from Volt Industries!\nPlease mail back this letter along with:\n1x Red Husk, 1x Cyan Husk1 and 1x Violet Husk.\nknowledge is power!'");
		}

		public override void SetDefaults() {
			Item.width = 25;
			Item.height = 12;
            Item.maxStack = 30;
            Item.rare = 1;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.value = Item.buyPrice(copper: 20);
		}
		
		public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.CopperCoin, 20);
            recipe.AddTile(null, "MysteriousMailboxTile");
            recipe.Register();
        }
    }
}