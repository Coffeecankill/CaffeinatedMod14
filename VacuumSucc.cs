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

namespace CaffinatedMod
{
    public class Class1 : ModPlayer
    {
        public bool ItemVacuumIsEquipped;

        public override void ResetEffects()
        {
            ItemVacuumIsEquipped = false;
        }
    }
}
