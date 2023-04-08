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
	//[AutoloadEquip(EquipType.Waist)]
	public class Blubber : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blubber");
			Tooltip.SetDefault("Increases maximum life by 50\n-10% movement speed\n'You feel heavy...'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 20;
			Item.maxStack = 1;
			Item.height = 20;
			Item.accessory = true;
			Item.value = Item.sellPrice(gold: 1);
			Item.rare = ItemRarityID.Green;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.moveSpeed -= 0.10f;
			player.jumpSpeedBoost -= 0.15f;
			player.extraFall -= 10;
			player.statLifeMax2 += 50;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.BowlofSoup, 1)
				.AddIngredient(ItemID.HealingPotion, 2)
				.AddIngredient(ItemID.CookedFish, 5)
				.AddIngredient(ItemID.Bottle, 1)
				.AddTile(TileID.CookingPots)
				.Register();
		}
	}
}