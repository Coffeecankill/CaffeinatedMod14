using Microsoft.Xna.Framework;
using Terraria.GameContent.Creative;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using CaffinatedMod.Projectiles;
using Terraria.Audio;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Placeable
{
	public class TavernMug : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Tavern Mug");
			Tooltip.SetDefault("<right> to become Tipsy\ntwitch.tv/beermanstan\n'Dilly Dilly!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() 
		{
			Item.useStyle = ItemUseStyleID.Swing;
			Item.holdStyle = ItemHoldStyleID.HoldFront;
			Item.useTurn = true;
			Item.useAnimation = 30;
			Item.useTime = 10;
			Item.autoReuse = true;
			Item.maxStack = 999;
			Item.rare = ItemRarityID.Cyan;
			Item.consumable = true;
			Item.createTile = TileType<Tiles.TavernMugTile>();
			Item.width = 18;
			Item.height = 18;
			Item.value = 5000;
		}

		public override void HoldStyle(Player player, Rectangle heldItemFrame) 
		{
			player.itemLocation += new Vector2( 1, 10 );
		}

		public override void AddRecipes()
		{
			CreateRecipe()
			.AddIngredient(ItemID.Mug, 1)
			.AddRecipeGroup("GoldBars", 2)
			.AddRecipeGroup("Wood", 2)
			.AddTile(TileID.Kegs)
			.Register();
		}
	}
}
