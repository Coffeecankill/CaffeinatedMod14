using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Letters
{
	public class QuestCompleteDPS : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Quest Complete: DPS Meter");
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
            recipe.AddIngredient(ItemID.SharkFin, 3);
			recipe.AddIngredient(ItemID.Coral, 5);
			recipe.AddIngredient(ItemID.Glowstick, 25);
			recipe.AddIngredient(Mod.Find<ModItem>("QuestLetterDPS").Type);
            recipe.Register();
        }
    }
}