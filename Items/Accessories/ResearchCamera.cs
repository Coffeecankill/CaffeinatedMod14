using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Accessories
{
	//[AutoloadEquip(EquipType.Neck)]
	public class ResearchCamera : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Research Camera");
			Tooltip.SetDefault("Increases critical strike chance by 7%\nIncreases armor penetration by 7\n'That thing's a miracle in technicolor, kid.'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.maxStack = 1;
			Item.height = 14;
			Item.accessory = true;
			Item.value = Item.sellPrice(gold: 2);
			Item.rare = ItemRarityID.Orange;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
        {
		player.GetCritChance(DamageClass.Generic) += 7;
		player.GetArmorPenetration(DamageClass.Generic) += 7; 
        }
	}
}