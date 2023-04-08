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
	public class HeavyCal : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Heavy Caliber Rounds");
			Tooltip.SetDefault("130% increased ranged damage\nHalved range attack speed");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 14;
			Item.maxStack = 1;
			Item.height = 28;
			Item.accessory = true;
			Item.value = Item.sellPrice(gold: 1);
			Item.rare = ItemRarityID.Green;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Ranged) += 1.30f;
			player.GetAttackSpeed(DamageClass.Ranged) -= 0.50f;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldCoin, 5);
			recipe.AddTile(null, "VendingMachineTileV2");
			recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldCoin, 3);
			recipe.AddTile(null, "VendingMachineTileV3");
			recipe.Register();
		}
	}
}