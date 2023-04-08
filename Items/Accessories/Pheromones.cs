using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Accessories
{
	public class Pheromones : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Pheromones");
			Tooltip.SetDefault("Enemies seem more attracted to you...");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 20;
			Item.maxStack = 1;
			Item.defense = 1;
			Item.height = 18;
			Item.accessory = true;
			Item.value = Item.sellPrice(silver: 1);
			Item.rare = ItemRarityID.Blue;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.aggro += 300;
			player.AddBuff(BuffID.Battle, 2);
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.Daybloom, 5)
				.AddIngredient(ItemID.AntlionMandible, 1)
				.AddTile(TileID.CookingPots)
				.Register();
		}
	}
}