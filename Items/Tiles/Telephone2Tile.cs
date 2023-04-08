using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Tiles
{
	public class Telephone2Tile : ModTile
	{
		public override void SetStaticDefaults() {
			Main.tileSolidTop[Type] = false;
			Main.tileFrameImportant[Type] = true;
			Main.tileWaterDeath[Type] = false;
			Main.tileTable[Type] = false;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.StyleOnTable1x1);
			TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.Table, TileObjectData.newTile.Width, 0);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Cursed Telephone");
			AddMapEntry(new Color(9, 66, 32), name);
			TileID.Sets.DisableSmartCursor[Type] = true;
			TileObjectData.addTile(Type);
			ItemDrop = ItemType<Items.Placeable.Telephone2>();
		}
		
		public override bool RightClick(int i, int j) {
			
            Player player = Main.LocalPlayer;
			
			player.TeleportationPotion();
			SoundEngine.PlaySound(new SoundStyle("CaffinatedMod/Sounds/Custom/TelephoneTeleport"));
			
			return true;
		}
		
		public override void MouseOver(int i, int j) {
			Player player = Main.LocalPlayer;
			player.noThrow = 2;
			player.cursorItemIconEnabled = true;
			player.cursorItemIconID = ItemType<Items.Placeable.Telephone2>();
			}

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
			Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 16, ItemType<Items.Placeable.Telephone2>());
		}
	}
}