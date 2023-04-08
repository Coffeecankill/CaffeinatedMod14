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
	public class CaskTile : ModTile
	{
		public override void SetStaticDefaults(){
			Main.tileSolidTop[Type] = false;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileTable[Type] = false;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
			TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.Table, TileObjectData.newTile.Width, 0);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Cask of Brew");
			AddMapEntry(new Color(50, 72, 70), name);
            _ = TileID.Sets.DisableSmartCursor[Type];
			TileObjectData.addTile(Type);
			AdjTiles = new int[] { TileID.CookingPots };
		}
		
		public override void KillMultiTile(int i, int j, int frameX, int frameY) {
			Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 16, ItemType<Items.Accessories.BrewCask>());
		}
	}
}