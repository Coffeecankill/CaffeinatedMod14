using System.Linq;
using CaffinatedMod.Items.Placeable;
using CaffinatedMod.Items.Letters;
using CaffinatedMod.Items.Packages;
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
    public class MysteriousMailboxTile : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileSolidTop[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileLighted[Type] = true;
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.Direction = TileObjectDirection.PlaceRight;
            TileObjectData.addAlternate(1);
            Main.tileWaterDeath[Type] = false;
            Main.tileTable[Type] = false;
            Main.tileLavaDeath[Type] = false;
            TileObjectData.newTile.UsesCustomCanPlace = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 16 };
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.Table, TileObjectData.newTile.Width, 0);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Mysterious Mailbox");
            AddMapEntry(new Color(18, 24, 42), name);
            _ = TileID.Sets.DisableSmartCursor[Type];
            TileObjectData.addTile(Type);
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {

            r = 0.1f;
            g = 0.1f;
            b = 0.3f;
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

            if (player.HeldItem.type == ModContent.ItemType<SnowPalletInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<SnowPalletInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<Placeable.SnowPallet>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<DirtPalletInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<DirtPalletInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<DirtPallet>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<SandPalletInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<SandPalletInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<SandPallet>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<StonePalletInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<StonePalletInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<StonePallet>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<SiltPackageInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<SiltPackageInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<SiltPackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<LStarInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<LStarInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<LStarPackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<Q1NailgunInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<Q1NailgunInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<Q1Package>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<PinkwardInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<PinkwardInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<PinkwardPackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<SS2AutoShotgunInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<SS2AutoShotgunInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<SS2Package>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<OWFragLauncherInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<OWFragLauncherInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<OWPackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<CaulkNBurnInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<CaulkNBurnInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<CaulkNBurnPackage>());
            }
            
            else if (player.HeldItem.type == ModContent.ItemType<XmasPresentInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<XmasPresentInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<XmasPackagePackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<AR2Invoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<AR2Invoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<AR2Package>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<HalloweenPresentInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<HalloweenPresentInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<HalloweenPackagePackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<VacuumInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<VacuumInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<VacuumPackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<ReaperInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<ReaperInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<ReaperPackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<CEPLasmaRifleInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<CEPLasmaRifleInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<CEPLasmaRiflePackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<BrutePlasmaRifleInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<BrutePlasmaRifleInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<BrutePlasmaRiflePackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<QuestCompleteSextant>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<QuestCompleteSextant>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<QuestPackageSextant>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<QuestCompleteWeather>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<QuestCompleteWeather>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<QuestPackageWeather>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<QuestCompletePocketGuide>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<QuestCompletePocketGuide>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<QuestPackagePocketGuide>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<QuestCompleteDPS>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<QuestCompleteDPS>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<QuestPackageDPS>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<QuestCompleteStopwatch>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<QuestCompleteStopwatch>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<QuestPackageStopwatch>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<QuestCompleteLifeform>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<QuestCompleteLifeform>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<QuestPackageLifeform>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<MannCoInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<MannCoInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<MannCoPackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<CameraInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<CameraInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<CameraPackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<FO3RailwayInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<FO3RailwayInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<FO3RailwayPackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<CarbineInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<CarbineInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<CarbinePackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<KnifeInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<KnifeInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<KnifePackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<JinxRLInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<JinxRLInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<JinxRLPackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<ChembowInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<ChembowInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<ChembowPackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<RaygunInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<RaygunInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<RaygunPackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<MP40Invoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<MP40Invoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<MP40Package>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<LostLetter>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<LostLetter>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<LostPackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<AER9Invoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<AER9Invoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<AER9Package>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<Q3NailgunInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<Q3NailgunInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<Q3NailgunPackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<PlasmaPackInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<PlasmaPackInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<PlasmaPackPackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<M6DInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<M6DInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<M6DPackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<LasgunInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<LasgunInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<LasgunPackage>());
            }

            else if (player.HeldItem.type == ModContent.ItemType<MagChargerInvoice>() && !(player.HeldItem == player.inventory[58]))
            {
                player.ConsumeItem(ModContent.ItemType<MagChargerInvoice>());
                NewitemResult = Item.NewItem(new EntitySource_TileInteraction(player, i, j), itemdroppos, ModContent.ItemType<MagChargerFolded>());
            }

            if (Main.netMode == 1 && NewitemResult >= 0)
            {
                NetMessage.SendData(MessageID.SyncItem, -1, -1, null, NewitemResult, 1f);
            }

            return true;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 16, ItemType<Items.Placeable.MysteriousMailbox>());
        }

        public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;
            player.noThrow = 2;
            player.cursorItemIconEnabled = true;
            player.cursorItemIconID = ItemType<Items.Placeable.MysteriousMailbox>();
        }
    }
}