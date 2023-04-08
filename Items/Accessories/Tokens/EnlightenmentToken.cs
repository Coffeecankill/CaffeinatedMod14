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
	public class EnlightenmentToken : CopperTokenAccessory
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Token of Enlightenment");
			Tooltip.SetDefault("15% reduced mana usage\nIncreases maximum mana by 40\nOnly one token can be equipped at a time");
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
			player.statManaMax2 += 40;
			player.manaCost -= 0.15f;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<BlankToken>(1)
				.AddIngredient(ItemID.Amethyst, 1)
				.Register();
		}
	}
}