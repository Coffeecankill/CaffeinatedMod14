using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items
{
	public class DreamBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Buildo Plastic");
			Tooltip.SetDefault("'A whispering presence can be felt within'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
			ItemID.Sets.SortingPriorityMaterials[Item.type] = 59;
		}

		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.rare = 0;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.value = Item.sellPrice(silver: 20);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.FallenStar, 3);
			recipe.AddTile(TileID.Furnaces);
			recipe.Register();
		}
	}
}