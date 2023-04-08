using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items
{
    public class CaffinatedItem : GlobalItem
    {

        public override void GrabRange(Item item, Player player, ref int grabRange)
        {
            if (Main.LocalPlayer.GetModPlayer<Class1>().ItemVacuumIsEquipped)
            {
                grabRange *= 12;
            }
        }
    }
}