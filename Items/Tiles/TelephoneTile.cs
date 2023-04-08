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
	public class TelephoneTile : ModTile
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
			name.SetDefault("Telephone");
			AddMapEntry(new Color(9, 66, 32), name);
			TileID.Sets.DisableSmartCursor[Type] = true;
			TileObjectData.addTile(Type);
			ItemDrop = ItemType<Items.Placeable.Telephone>();
		}
		
		public override bool RightClick(int i, int j) {
			
            Player player = Main.LocalPlayer;
			
			player.Spawn(PlayerSpawnContext.RecallFromItem);
			SoundEngine.PlaySound(new SoundStyle("CaffinatedMod/Sounds/Custom/TelephoneTeleport"));
			
			for (int d = 0; d < 50; d++) {
					Dust.NewDust(player.position, player.width, player.height, 15, 0f, 0f, 150, default(Color), 1.5f);
			}
			return true;
		}
		
		public override void MouseOver(int i, int j) {
			Player player = Main.LocalPlayer;
			player.noThrow = 2;
			player.cursorItemIconEnabled = true;
			player.cursorItemIconID = ItemType<Items.Placeable.Telephone>();
			}

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
			Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 16, ItemType<Items.Placeable.Telephone>());
		}
	}
}