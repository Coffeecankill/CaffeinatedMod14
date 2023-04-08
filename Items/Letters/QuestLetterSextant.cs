using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Letters
{
	public class QuestLetterSextant : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Quest Letter: Sextant");
			Tooltip.SetDefault("'Greetings from Volt Industries!\nPlease mail back this letter along with:\n1x Golden Carp. It's great for\navoiding werewolf attacks!'");
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