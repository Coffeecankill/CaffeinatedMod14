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
	public class SandPalletTile : ModTile
	{
		public override void SetStaticDefaults()
        {
            Main.tileSolidTop[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = false;
            Main.tileLavaDeath[Type] = false;
            TileObjectData.newTile.UsesCustomCanPlace = true;
            TileObjectData.newTile.Width = 3;
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 16, 18 };
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width - 2, 0);
            TileObjectData.newTile.CoordinatePadding = 2;
			TileObjectData.newTile.CoordinateWidth = 16;
			TileObjectData.newTile.Origin = new Point16(0, 0);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Pallet of Sand");
            AddMapEntry(new Color(72, 65, 32), name);
            TileID.Sets.DisableSmartCursor[Type] = true;
			TileObjectData.addTile(Type);
        }

		public override void KillMultiTile(int i, int j, int frameX, int frameY) {
			object p = Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 16, ItemType<Items.Placeable.SandPallet>()); 
		}
	}
}