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
	public class MiningToken : CopperTokenAccessory
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Dwarven Mining Token");
			Tooltip.SetDefault("30% increased mining speed\nProvides light when worn\nOnly one token can be equipped at a time\n'Did I hear a Rock and Stone!?'");
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
			player.pickSpeed -= 0.30f;
			Lighting.AddLight((int)(player.position.X + (float)(player.width / 2)) / 16, (int)(player.position.Y + (float)(player.height / 2)) / 16, .9f, 0.8f, 0.6f);
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<BlankToken>(1)
				.AddIngredient(ItemID.Topaz, 1)
				.Register();
		}
	}
}