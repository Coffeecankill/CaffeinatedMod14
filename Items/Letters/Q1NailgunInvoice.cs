using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Letters
{
	public class Q1NailgunInvoice : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Peculiar Invoice");
			Tooltip.SetDefault("Orders a machine gun from\nan alternate dimension, deposit\nthis into the Mysterious Mailbox");
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
			recipe.AddIngredient(ItemID.CrimeraBanner, 1);
			recipe.AddIngredient(ItemID.ZombieBanner, 2);
			recipe.AddIngredient(Mod.Find<ModItem>("StampedLetter").Type);
			recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.EaterofSoulsBanner, 1);
			recipe.AddIngredient(ItemID.ZombieBanner, 2);
			recipe.AddIngredient(Mod.Find<ModItem>("StampedLetter").Type);
			recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.CrimeraBanner, 1);
			recipe.AddIngredient(ItemID.ZombieEskimoBanner, 2);
			recipe.AddIngredient(Mod.Find<ModItem>("StampedLetter").Type);
			recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.EaterofSoulsBanner, 1);
			recipe.AddIngredient(ItemID.ZombieEskimoBanner, 2);
			recipe.AddIngredient(Mod.Find<ModItem>("StampedLetter").Type);
			recipe.Register();
		}
    }
}