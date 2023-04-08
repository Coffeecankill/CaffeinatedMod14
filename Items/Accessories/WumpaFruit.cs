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
	//[AutoloadEquip(EquipType.Back)]
	public class WumpaFruit : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Wumpa Fruit");
			Tooltip.SetDefault("10% increased damage when worn\n10% increased movement speed when worn\n'Delectable!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 24;
			Item.maxStack = 1;
			Item.height = 24;
			Item.accessory = true;
			Item.value = Item.sellPrice(gold: 1);
			Item.rare = ItemRarityID.Lime;
			Item.useStyle = ItemUseStyleID.DrinkLiquid;
			Item.useAnimation = 17;
			Item.useTime = 17;
			Item.consumable = true;
			Item.healLife = 350;
			Item.potion = true;
			Item.UseSound = SoundID.Item2;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Generic) += 0.10f;
			player.moveSpeed += 0.10f;
		}
	}
}