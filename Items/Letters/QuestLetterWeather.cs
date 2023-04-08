using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Letters
{
	public class QuestLetterWeather : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Quest Letter: Weather Radio");
			Tooltip.SetDefault("'Greetings from Volt Industries!\nPlease mail back this letter along with:\n15x Clouds, 15x Rain clouds, and 5x Feathers.\nNever miss a sunny day again!'");
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