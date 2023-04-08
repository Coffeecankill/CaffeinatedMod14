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
	public class StrangeCrystals : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Strange Crystals");
			Tooltip.SetDefault("30% increased movement speed\nYou can run super fast\n'They have a sweet taste\nand are cold to the touch'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() 
		{
			Item.width = 26;
			Item.maxStack = 1;
			Item.height = 14;
			Item.accessory = true;
			Item.value = Item.sellPrice(gold: 1);
			Item.rare = ItemRarityID.Blue;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
        {
        player.moveSpeed += 0.3f;
		player.accRunSpeed = 6f;
		player.jumpSpeedBoost += 0.3f;
        }

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.Shiverthorn, 5)
				.AddIngredient(ItemID.Bowl, 1)
				.AddIngredient(ItemID.PinkGel, 10)
				.AddIngredient(ItemID.BottledWater, 5)
				.AddTile(TileID.CookingPots)
				.Register();
		}
	}
}