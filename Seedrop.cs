using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod
{
    public class Class2 : GlobalTile
    {

        public override void KillTile(int i, int j, int type, ref bool fail, ref bool effectOnly, ref bool noItem)
        {

            Player closestPlayer = Main.player[(int)Player.FindClosest(new Vector2((float)(i * 16), (float)(j * 16)), 16, 16)];

            Tile tile = Main.tile[i, j];

            if (tile.TileType == TileID.Plants || tile.TileType == TileID.Plants2 || tile.TileType == TileID.JunglePlants)
			{
				if (Main.player[Main.myPlayer].inventory.Any(a => a.type == ItemType<Items.Weapons.PneumaticPopper>()))
				{
                    Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 16, ItemID.Seed, 2);
                }
				if (Main.player[Main.myPlayer].inventory.Any(a => a.type == ItemType<Items.Weapons.PneumaticPopperTin>()))
				{
                    Item.NewItem(new EntitySource_TileBreak(i, j),i * 16, j * 16, 32, 16, ItemID.Seed, 2);
                }
			}
		}
	}
}