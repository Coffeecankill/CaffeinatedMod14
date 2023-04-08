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
	public class MagicSuper : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Magical Supercharger");
			Tooltip.SetDefault("Increases your magic damage by 40%\nDecreases maximum mana by 100\n'You feel the power surging\nthrough your veins!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.maxStack = 1;
			Item.height = 28;
			Item.accessory = true;
			Item.value = Item.sellPrice(gold: 2);
			Item.rare = ItemRarityID.Orange;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
        {
        player.statManaMax2 -= 100;
		player.GetDamage(DamageClass.Magic) += 0.40f;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.Sapphire, 8)
				.AddIngredient(ItemID.Bone, 15)
				.AddIngredient(ItemID.ManaCrystal, 4)
				.AddTile(TileID.DemonAltar)
				.Register();

		}
	}
}