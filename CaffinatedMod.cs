using CaffinatedMod.Items.Placeable;
using CaffinatedMod.Items.Tiles;
using Microsoft.Xna.Framework;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using Terraria;
using Terraria.GameContent.Biomes.CaveHouse;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace CaffinatedMod
{
    public class CaffinatedMod : Mod
    {
        public override void Load() {
            base.Load();

            On.Terraria.GameContent.Biomes.CaveHouse.HouseBuilder.FillRooms += (orig, self) =>
            {
                // 1/5 chance to place.
                if (WorldGen.genRand.NextBool(5)) {
                    foreach (Rectangle room in self.Rooms) {
                        int x = WorldGen.genRand.Next(room.Width - 3) + 1 + room.X;
                        int y = room.Y + room.Height - 2;
                        WorldGen.PlaceTile(x, y, ModContent.TileType<VendingMachineTile>(), mute: true, forced: false);
                    }
                }

                orig(self);
            };

            /*IL.Terraria.GameContent.Biomes.CaveHouse.HouseBuilder.FillRooms += il =>
        {
            ILCursor c = new(il);
            
            il.Body.Variables.Add(new VariableDefinition(il.Import(typeof(bool))));
            int placeVendingMachineLocal = il.Body.Variables.Count - 1;
            
            // Set placeVendingMachine
            c.EmitDelegate(() => WorldGen.genRand.NextBool(5));
            c.Emit(OpCodes.Stloc, placeVendingMachineLocal);

            // Change BookscaleStyle
            c.GotoNext(MoveType.After, x => x.MatchCall<HouseBuilder>("get_BookcaseStyle"));
            c.Emit(OpCodes.Pop);
            c.Emit(OpCodes.Ldarg_0);
            c.Emit(OpCodes.Ldloc, placeVendingMachineLocal);
            c.EmitDelegate((HouseBuilder builder, bool placeVendingMachine) => placeVendingMachine ? 0 : builder.BookcaseStyle);
            
            // Change bookcase tile ID
            c.GotoPrev(MoveType.After, x => x.MatchLdcI4(TileID.Bookcases));
            c.Emit(OpCodes.Pop);
            c.Emit(OpCodes.Ldloc, placeVendingMachineLocal);
            c.EmitDelegate((bool placeVendingMachine) => placeVendingMachine ? ModContent.TileType<VendingMachineTile>() : TileID.Bookcases);
        };*/
        }
    }

    public abstract class CopperTokenAccessory : ModItem
    {

        public override void SetDefaults()
        {
            Item.accessory = true;
        }

        public override bool CanAccessoryBeEquippedWith(Item equippedItem, Item incomingItem, Player player)
        {
            if (equippedItem.ModItem is CopperTokenAccessory && incomingItem.ModItem is CopperTokenAccessory)
                return false;
            return true;
        }
    }

    public class CaffinatedRecipeGroups : ModSystem
    {
        public override void AddRecipeGroups() {
        base.AddRecipeGroups();

        RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("") + "Copper/Tin Bar",
            new int[]
            {
            ItemID.CopperBar,
            ItemID.TinBar });
            RecipeGroup.RegisterGroup("CopperBars", group);

            RecipeGroup group2 = new RecipeGroup(() => Language.GetTextValue("") + "Gold/Platinum Bar",
            new int[]
            {
            ItemID.GoldBar,
            ItemID.PlatinumBar });
            RecipeGroup.RegisterGroup("GoldBars", group2);

            RecipeGroup group3 = new RecipeGroup(() => Language.GetTextValue("") + "Any Evil Bar",
            new int[]
            {
            ItemID.CrimtaneBar,
            ItemID.DemoniteBar });
            RecipeGroup.RegisterGroup("EvilBars", group3);
        }
    }
}