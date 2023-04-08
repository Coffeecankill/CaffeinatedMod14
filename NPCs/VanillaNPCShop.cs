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
    public class VanillaNPCShop : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.Merchant:
                    {
                        if (Main.player[Main.myPlayer].inventory.Any(i => i.type == ItemType<Items.Weapons.BlackJackFlareGun>()))
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.Flare);
                            nextSlot++;
                            shop.item[nextSlot].SetDefaults(ItemID.BlueFlare);
                            nextSlot++;
                        }
                        break;
                    }
            }
        }
    }
}