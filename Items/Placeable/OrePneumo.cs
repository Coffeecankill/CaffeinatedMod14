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
	public class OrePneumo : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ore Pneumo");
			Tooltip.SetDefault("'Order our ores!'\nSupplied by Volt Industries");
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
			Item.rare = ItemRarityID.Orange;
			Item.consumable = true;
			Item.createTile = TileType<Tiles.OrePneumoTile>();
			Item.width = 48;
			Item.height = 32;
			Item.value = 10000;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddRecipeGroup("IronBar", 12)
				.AddIngredient(ItemID.ManaCrystal, 1)
				.AddIngredient(ItemID.Bone, 20)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}