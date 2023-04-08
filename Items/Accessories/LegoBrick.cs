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
	public class LegoBrick : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Buildo Brick");
			Tooltip.SetDefault("Increases your max number of sentries by 1\n'Defend the HYPERCORE!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 18;
			Item.maxStack = 1;
			Item.height = 14;
			Item.defense = 2;
			Item.accessory = true;
			Item.value = Item.sellPrice(silver: 50);
			Item.rare = ItemRarityID.Green;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.maxTurrets += 1;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<DreamBar>(4)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}