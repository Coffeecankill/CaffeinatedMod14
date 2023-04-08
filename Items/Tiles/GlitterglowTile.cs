using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.WorldBuilding;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Tiles
{
	public class GlitterglowTile : ModTile
	{
		public override void SetStaticDefaults() {
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTorch);
			Main.tileWaterDeath[Type] = false;
			Main.tileLavaDeath[Type] = false;
			AddMapEntry(new Color(15, 36, 61));
			HitSound = new SoundStyle("Terraria/Sounds/Item_50");
		}

		public override bool Drop(int i, int j) {
			Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 16, ItemType<Items.Placeable.Glitterglow>());
			return base.Drop(i, j);
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b) {
			
			r = 0.7f;
			g = 1.0f;
			b = 1.5f;

		}

		public class CaffinatedSystem : ModSystem
		{
			public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
			{
				int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));

				if (ShiniesIndex != -1)
				{
					tasks.Insert(ShiniesIndex + 1, new CaffinatedOrePass("Glitterglow", 237.4298f));
				}
			}
		}

		public class CaffinatedOrePass : GenPass
		{
			public CaffinatedOrePass(string name, float loadWeight) : base(name, loadWeight)
			{
			}

			protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
			{

				progress.Message = "Glitterglow!";

				for (int k = 0; k < (int)(Main.maxTilesX * Main.maxTilesY * 6E-05); k++)
				{

					int x = WorldGen.genRand.Next(0, Main.maxTilesX);

					int y = WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY);

					WorldGen.TileRunner(x, y, WorldGen.genRand.Next(2, 5), WorldGen.genRand.Next(2, 3), ModContent.TileType<GlitterglowTile>());

				}
			}
		}
	}
}