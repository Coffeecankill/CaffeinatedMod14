using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Placeable
{
	public class Television : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Television");
			Tooltip.SetDefault("'The best part of any room!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.useStyle = 1;
			Item.useTurn = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.autoReuse = true;
			Item.maxStack = 99;
			Item.rare = ItemRarityID.White;
			Item.consumable = true;
			Item.createTile = TileType<Tiles.TelevisionTile>();
			Item.width = 48;
			Item.height = 34;
			Item.value = 3000;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddRecipeGroup("CopperBars", 3)
				.AddRecipeGroup("Wood", 15)
				.AddIngredient(ItemID.Glass, 8)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}