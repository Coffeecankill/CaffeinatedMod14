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
	[AutoloadEquip(EquipType.Back)]
    public class MushroomLamp: ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glowing Mushroom Buddy");
            Tooltip.SetDefault("Provides light when worn\n'I've got your back!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

        public override void SetDefaults()
        {
            Item.maxStack = 1;
            Item.accessory = true;
			Item.defense = 2;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(gold: 1);
			}		
			
		public override void UpdateAccessory(Player player, bool hideVisual)
        {
        Lighting.AddLight((int)(player.position.X + (float)(player.width / 2)) / 16, (int)(player.position.Y + (float)(player.height / 2)) / 16, .2f, 0.4f, 0.9f);
        }
		
			public override void AddRecipes()
			{
			CreateRecipe()
				.AddIngredient(ItemID.ClayPot, 1)
				.AddIngredient(ItemID.MushroomGrassSeeds, 3)
				.AddIngredient(ItemID.MudBlock, 5)
				.AddIngredient(ItemID.Shackle, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
			}
	}
}