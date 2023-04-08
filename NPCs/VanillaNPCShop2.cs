/*
using Microsoft.Xna.Framework;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.NPCs
{
    public class VanillaNPCShop2 : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.ArmsDealer:
                    {
                       if (Main.hardMode)
                       {
                       shop.item[nextSlot].SetDefaults(ItemType<Items.Weapons.Thompson>());
                       nextSlot++;
                       }
                        break;
                    }
            }
        }
    }
}
*/