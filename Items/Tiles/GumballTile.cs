using System.Linq;
using CaffinatedMod.Items.Placeable;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.ObjectInteractions;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Tiles
{
    public class GumballTile : ModTile
    {
        private readonly int[] itemDrops =
        {
            ModContent.ItemType<Buffs.HealthBall>(),
            ModContent.ItemType<Buffs.SpeedBall>(),
            ModContent.ItemType<Buffs.FallBall>(),
            ModContent.ItemType<Buffs.BlueBall>(),
            ModContent.ItemType<Buffs.FireBall>(),
            ModContent.ItemType<Buffs.FastBall>(),
            ModContent.ItemType<Buffs.ArmorBall>()
        };

        public override void SetStaticDefaults()
        {
            Main.tileSolidTop[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileLighted[Type] = false;
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.Direction = TileObjectDirection.PlaceRight;
            TileObjectData.addAlternate(1);
            Main.tileWaterDeath[Type] = false;
            Main.tileTable[Type] = false;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.UsesCustomCanPlace = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 16 };
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.Table, TileObjectData.newTile.Width, 0);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Gumball Machine");
            AddMapEntry(new Color(86, 23, 23), name);
            _ = TileID.Sets.DisableSmartCursor[Type];
            TileObjectData.addTile(Type);
        }

        public override bool HasSmartInteract(int i, int j, SmartInteractScanSettings settings) {
            return true;
        }

        public override bool RightClick(int i, int j)
        {
            Player player = Main.LocalPlayer;

            if (player.HeldItem.IsAir)
            {
                return false;
            }

            Rectangle itemdroppos = new Rectangle(i * 16, j * 16, player.width, player.height);
            int NewitemResult = 0;

            if (player.HeldItem.type == (ItemID.SilverCoin) && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ItemID.SilverCoin);
                
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, Main.rand.Next(itemDrops));

                if (Main.netMode == 1 && NewitemResult >= 0)
                {
                    NetMessage.SendData(MessageID.SyncItem, -1, -1, null, NewitemResult, 1f);
                }
            }
            
            return true;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 16, ItemType<Items.Placeable.Gumball>());
        }

        public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;
            player.noThrow = 2;
            player.cursorItemIconEnabled = true;
            player.cursorItemIconID = ItemType<Items.Placeable.Gumball>();
        }
    }
}