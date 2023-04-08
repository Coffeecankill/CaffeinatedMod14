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
	[AutoloadEquip(EquipType.Face)]
	public class IceBlock: ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magic Ice Block");
            Tooltip.SetDefault("Immune to fire and lava\nYou are chilled");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
			ArmorIDs.Face.Sets.PreventHairDraw[Item.faceSlot] = true;
			//ArmorIDs.Face.Sets.DrawInFaceHeadLayer[Item.faceSlot] = true;
			ArmorIDs.Face.Sets.OverrideHelmet[Item.faceSlot] = true;
		}

        public override void SetDefaults()
        {
			Item.width = 16;
			Item.height = 16;
			Item.maxStack = 1;
            Item.accessory = true;
			Item.rare = ItemRarityID.Blue;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.lavaImmune = true;
			player.fireWalk = true;
			player.AddBuff(BuffID.Chilled, 2);
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.IceBlock, 5)
				.AddIngredient(ItemID.ManaCrystal, 1)
				.Register();
		}
	}
}