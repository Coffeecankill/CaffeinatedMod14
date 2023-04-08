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
        class ItemVacuum: ModItem
        {

            public override void SetStaticDefaults()
            {
                DisplayName.SetDefault("Item Vacuum");
                Tooltip.SetDefault("Greatly increases item pickup range\n'The Model 400 Backvac'");
                CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            }

        public override void SetDefaults()
        {
            Item.maxStack = 1;
            Item.accessory = true;
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.buyPrice(gold: 1);
			}		
			
			public override void UpdateAccessory(Player player, bool hideVisual)
            {
            player.GetModPlayer<Class1>().ItemVacuumIsEquipped = true;
			}
	    }
}