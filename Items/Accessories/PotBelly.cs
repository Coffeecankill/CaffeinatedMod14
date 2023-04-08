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
	public class PotBelly : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pot Belly Stove");
			Tooltip.SetDefault("Increased life regeneration when worn\nProvides light when worn\n-15% movement speed when worn\nFunctions as a furnace when placed\n'Wow that's heavy!'");
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
			Item.defense = 9;
			Item.accessory = true;
			Item.consumable = true;
			Item.createTile = TileType<Tiles.PotBellyTile>();
			Item.value = Item.sellPrice(silver: 5);
			Item.rare = ItemRarityID.Blue;
			Item.width = 32;
			Item.height = 34;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.moveSpeed -= 0.15f;
			player.jumpSpeedBoost -= 0.3f;
			player.extraFall -= 20;
			player.AddBuff(BuffID.Campfire, 2);
			Lighting.AddLight((int)(player.position.X + (float)(player.width / 2)) / 16, (int)(player.position.Y + (float)(player.height / 2)) / 16, .8f, 0.2f, 0.2f);
		}
		public override void AddRecipes()
		{
			CreateRecipe()
			.AddRecipeGroup("IronBar", 14)
			.AddIngredient(ItemID.Campfire, 1)
			.AddTile(TileID.Anvils)
			.Register();
		}
	}
}