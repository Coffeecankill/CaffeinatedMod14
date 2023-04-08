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
    public class VanillaNPCShop4 : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {

                case NPCID.Demolitionist:
                    {
                        if (Main.player[Main.myPlayer].inventory.Any(i => i.type == ItemType<Items.Weapons.OWFragLauncher>()))
                        {
                            shop.item[nextSlot].SetDefaults(ItemType<Items.Rocket1Satchel>());
                            nextSlot++;
                        }
                        if (Main.player[Main.myPlayer].inventory.Any(i => i.type == ItemType<Items.Weapons.BioshockLauncher>()))
                        {
                            shop.item[nextSlot].SetDefaults(ItemType<Items.Rocket1Satchel>());
                            nextSlot++;
                        }
                        if (Main.player[Main.myPlayer].inventory.Any(i => i.type == ItemType<Items.Weapons.Trailblazer>()))
                        {
                            shop.item[nextSlot].SetDefaults(ItemType<Items.Rocket1Satchel>());
                            nextSlot++;
                        }
                        if (Main.player[Main.myPlayer].inventory.Any(i => i.type == ItemType<Items.Weapons.Q1ProxyLauncher>()))
                        {
                            shop.item[nextSlot].SetDefaults(ItemType<Items.Rocket1Satchel>());
                            nextSlot++;
                        }
                        if (Main.player[Main.myPlayer].inventory.Any(i => i.type == ItemType<Items.Weapons.JinxRL>()))
                        {
                            shop.item[nextSlot].SetDefaults(ItemType<Items.Rocket1Satchel>());
                            nextSlot++;
                        }
                        break;
                    }
            }
        }
    }
}