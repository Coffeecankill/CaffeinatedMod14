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

namespace CaffinatedMod.Items.Accessories.Tokens
{
	public class FishingToken : CopperTokenAccessory
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Fishing Token");
			Tooltip.SetDefault("Fishing line will never break,\ndecreases chance of bait consumption,\nincreases fishing power by 10\nOnly one token can be equipped at a time");
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

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.accFishingLine = true;
			player.accTackleBox = true;
			player.fishingSkill += 10;
		}
		/*
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<BlankToken>(1)
				.AddIngredient(ItemID.Sapphire, 1)
				.Register();
		} */
	}
}