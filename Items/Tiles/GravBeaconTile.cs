using System.Linq;
using CaffinatedMod.Items.Placeable;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent.ObjectInteractions;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Tiles
{
    public class GravBeaconTile : ModTile
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
            TileObjectData.newTile.UsesCustomCanPlace = true;
            TileObjectData.newTile.Width = 3;
            TileObjectData.newTile.Height = 5;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 16, 16, 18 };
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width - 2, 0);
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Gravity Beacon");
            AddMapEntry(new Color(4, 44, 44), name);
            TileID.Sets.DisableSmartCursor[Type] = true;
           
        }
		
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b) {
			
			r = 0.10f;
			g = 0.35f;
			b = 0.25f;
		}

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (closer)
            {
                Player player = Main.LocalPlayer;
                player.AddBuff(BuffID.Featherfall, 125, true);
            }
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            object p = Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 16, ItemType<Items.Placeable.GravBeacon>()); 
        }
    }
}