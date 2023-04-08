using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;
using CaffinatedMod.Systems.Kleptomancy;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Accessories.Tokens
{
	public class KleptomancyToken : CopperTokenAccessory
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Kleptomancy");
			Tooltip.SetDefault("Each attack against an enemy has a chance\nof granting 1 Silver, and also has a chance\nto instead grant a consumable item.\nOnly one token can be equipped at a time\n*Recommended to keep items in hotbar");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.accessory = true;
			Item.width = 28;
			Item.height = 28;
			Item.maxStack = 1;
			Item.rare = 4;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 1;
			Item.value = Item.buyPrice(gold: 1);
			
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetModPlayer<KleptomancyPlayer>().Kleptomancer = true;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<BlankToken>(1)
				.AddIngredient(ItemID.GoldCoin, 1)
				.AddRecipeGroup("GoldBars", 3)
				.Register();
		}
	}
}