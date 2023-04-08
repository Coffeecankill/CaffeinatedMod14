using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Letters
{
	public class QuestCompleteStopwatch : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Quest Complete: Stopwatch");
			Tooltip.SetDefault("'Redeem this at the mysterious mailbox.'");
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
            recipe.AddIngredient(ItemID.GlowingMushroom, 20);
			recipe.AddIngredient(ItemID.Hook, 1);
			recipe.AddIngredient(Mod.Find<ModItem>("QuestLetterStopwatch").Type);
            recipe.Register();
        }
    }
}