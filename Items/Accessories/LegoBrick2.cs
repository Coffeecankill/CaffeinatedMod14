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
	public class LegoBrick2 : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Duildo Brick");
			Tooltip.SetDefault("Increases your max number of sentries by 1\n'Extra tough and durable!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 18;
			Item.maxStack = 1;
			Item.height = 14;
			Item.defense = 4;
			Item.accessory = true;
			Item.value = Item.sellPrice(silver: 50);
			Item.rare = ItemRarityID.LightRed;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.maxTurrets += 1;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<DreamBar>(5)
				.AddIngredient(ItemID.PixieDust, 5)
				.AddTile(TileID.Anvils)
				.Register();

			CreateRecipe()
				.AddIngredient<LegoBrick>(1)
				.AddIngredient(ItemID.PixieDust, 5)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}