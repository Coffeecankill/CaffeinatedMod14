using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Tiles
{
    public class VendingMachineTileV2 : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileSolidTop[Type] = false;
			Main.tileBlockLight[Type] = false;
			Main.tileWaterDeath[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = false;
            Main.tileLavaDeath[Type] = false;
			Main.tileLighted[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style3x4);
			TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width - 2, 0);
			TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Vending Machine Mk.II");
            AddMapEntry(new Color(36, 34, 63), name);
            TileID.Sets.DisableSmartCursor[Type] = true;
        }
		
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b) {
			
			r = 0.25f;
			g = 0.25f;
			b = 0.45f;
		}

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            object p = Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 16, ItemType<Items.Placeable.VendingMachineV2>()); 
        }
    }
}