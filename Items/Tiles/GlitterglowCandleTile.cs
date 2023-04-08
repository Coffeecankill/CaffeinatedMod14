using System.Linq;
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
	public class GlitterglowCandleTile : ModTile
	{
        private int drop;

        public override void SetStaticDefaults() {
			Main.tileSolidTop[Type] = false;
			Main.tileFrameImportant[Type] = true;
			Main.tileLighted[Type] = true;
			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTorch);
			Main.tileWaterDeath[Type] = false;
			Main.tileTable[Type] = false;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.StyleOnTable1x1);
			TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.Table, TileObjectData.newTile.Width, 0);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Glitterglow Candle");
			AddMapEntry(new Color(9, 66, 32), name);
			_ = TileID.Sets.DisableSmartCursor[Type];
			TileObjectData.addTile(Type);
			ItemDrop = ItemType<Items.Placeable.GlitterglowCandle>();
		}
		
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b) {

            r = 0.6f;
			g = 0.9f;
			b = 1.7f;
			
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 16, ItemType<Items.Placeable.GlitterglowCandle>());
		}
	}
}