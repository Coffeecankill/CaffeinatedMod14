using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.GameContent.Creative;
using Terraria.DataStructures;
using Terraria.Enums;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Placeable
{
	public class Washer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Laundry machine");
			Tooltip.SetDefault("<right> to cleanse debuffs\n'The Wash-O-Matic 600 hates\nstains and removes them with\nEXTREME prejudice!'");
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
			Item.rare = ItemRarityID.Blue;
			Item.consumable = true;
			Item.createTile = TileType<Tiles.WasherTile>();
			Item.width = 32;
			Item.height = 34;
			Item.value = 3000;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddRecipeGroup("IronBar", 12)
				.AddIngredient(ItemID.Glass, 5)
				.AddRecipeGroup("CopperBars", 3)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}