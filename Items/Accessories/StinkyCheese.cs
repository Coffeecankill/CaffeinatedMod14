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
	[AutoloadEquip(EquipType.Back)]
	public class StinkyCheese : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Stinky Cheese Wheel");
			Tooltip.SetDefault("Greatly increased life regen when worn\n'Atleast it tastes good'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 24;
			Item.maxStack = 1;
			Item.height = 24;
			Item.accessory = true;
			Item.value = Item.sellPrice(gold: 1);
			Item.rare = ItemRarityID.Green;
			Item.useStyle = ItemUseStyleID.DrinkLiquid;
			Item.useAnimation = 17;
			Item.useTime = 17;
			Item.consumable = true;
			Item.healLife = 150;
			Item.potion = true;
			Item.UseSound = SoundID.Item2;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.AddBuff(BuffID.Stinky, 2);
			player.lifeRegen += 6;
		}

		public override void OnConsumeItem(Player player)
		{
			player.AddBuff(BuffID.WellFed, 108000);
		}
	}
}