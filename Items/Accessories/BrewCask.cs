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
	public class BrewCask : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cask of Brew");
			Tooltip.SetDefault("Reduces damage taken by 20%\n15% increased movement speed\nDecreases maximum life by 75\n'Has a strong tart taste'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.maxStack = 1;
			Item.useStyle = 1;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			//Item.defense = 10;
			Item.accessory = true;
			Item.consumable = true;
			Item.createTile = TileType<Tiles.CaskTile>();
			Item.value = Item.sellPrice(gold: 2);
			Item.rare = ItemRarityID.Orange;
			Item.width = 32;
			Item.height = 34;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.moveSpeed += 0.15f;
			player.statLifeMax2 -= 75;
			player.endurance += 0.20f;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.Barrel, 1)
				.AddIngredient(ItemID.Bone, 15)
				.AddIngredient(ItemID.IronskinPotion, 3)
				.AddIngredient(ItemID.SwiftnessPotion, 3)
				.AddIngredient(ItemID.BottledWater, 5)
				.AddTile(TileID.CookingPots)
				.Register();
		}
	}
}