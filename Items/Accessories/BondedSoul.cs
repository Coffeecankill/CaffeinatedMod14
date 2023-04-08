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
	public class BondedSoul : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Bonded Soul");
			Tooltip.SetDefault("Increases your max number of minions by 3\nDecreases minion damage by 33%\n'We fight as one'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 22;
			Item.maxStack = 1;
			Item.height = 22;
			Item.accessory = true;
			Item.value = Item.sellPrice(gold: 2);
			Item.rare = ItemRarityID.Orange;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
        {
        player.maxMinions += 3;
		player.GetDamage(DamageClass.Summon) -= 0.33f;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.JackOLantern, 1)
				.AddIngredient(ItemID.Book, 1)
				.AddIngredient(ItemID.ManaCrystal, 1)
				.AddTile(TileID.DemonAltar)
				.Register();
		}
	}
}