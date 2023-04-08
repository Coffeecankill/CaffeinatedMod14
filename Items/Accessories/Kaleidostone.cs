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

	public class Kaleidostone : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kaleidostone");
			Tooltip.SetDefault("Reduces damage taken by 65%\nReduces damage dealt by 40%\n'It's a flawless gemstone'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.maxStack = 1;
			Item.useStyle = 1;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.accessory = true;
			Item.value = Item.sellPrice(gold: 2);
			Item.rare = ItemRarityID.Blue;
			Item.width = 30;
			Item.height = 40;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Generic) -= 0.40f;
			player.endurance += 0.65f;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.Amber, 3)
				.AddIngredient(ItemID.Amethyst, 3)
				.AddIngredient(ItemID.Topaz, 3)
				.AddIngredient(ItemID.Diamond, 3)
				.AddIngredient(ItemID.Sapphire, 3)
				.AddIngredient(ItemID.Ruby, 3)
				.AddIngredient(ItemID.Emerald, 3)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}