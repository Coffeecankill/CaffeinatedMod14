#nullable enable

using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent.ObjectInteractions;
using Terraria.ModLoader;
using CaffinatedMod.Items;
using CaffinatedMod.Items.Placeable;
using static Terraria.ModLoader.ModContent;


namespace CaffinatedMod.Systems.Kleptomancy
{
    public sealed class KleptomancySystem : ModSystem
    {
        public readonly List<int> KleptoItems = new();

        public override void PostAddRecipes()
        {
            base.PostAddRecipes();

            KleptoItems.Add((ModContent.ItemType<Items.Placeable.Pinkward>()));
            KleptoItems.Add((ModContent.ItemType<Items.BagOGold>()));
            KleptoItems.Add(ItemID.LesserManaPotion);
            KleptoItems.Add((ModContent.ItemType<Items.PilferedHealthPotion>())); 
            KleptoItems.Add((ModContent.ItemType<Items.TotalBiscuit>()));
            KleptoItems.Add((ModContent.ItemType<Items.RoguePotion>()));
            KleptoItems.Add((ModContent.ItemType<Items.OracleExtract>()));
            KleptoItems.Add((ModContent.ItemType<Items.TravelIron>()));
            KleptoItems.Add((ModContent.ItemType<Items.TravelSorcery>()));
            KleptoItems.Add((ModContent.ItemType<Items.WrathElixor>()));
        }

        public override void Unload()
        {
            base.Unload();

            KleptoItems.Clear();
        }

        public void RollKlepto(Player player, NPC npc)
        {
            if (Main.netMode == NetmodeID.Server)
                return;

            if (Main.netMode == NetmodeID.MultiplayerClient && player.whoAmI != Main.myPlayer)
                return;

            int? whoAmI = null;
            var source = player.GetSource_OnHit(npc, "Kleptomancy");
            if (npc.type != NPCID.TargetDummy)

                switch (Main.rand.Next(24))
                {
                case 0:
                    whoAmI = Item.NewItem(source, player.position, ItemID.SilverCoin);
                    break;

                case 1:
                    var item = KleptoItems[Main.rand.Next(KleptoItems.Count)];
                    whoAmI = Item.NewItem(source, player.position, item);
                    break;

                case 2:
                    whoAmI = Item.NewItem(source, player.position, ItemID.SilverCoin);
                    break;

                        // 2-3 ignored; 50% chance to drop anything
                }

            if (whoAmI.HasValue && Main.netMode == NetmodeID.MultiplayerClient)
                NetMessage.SendData(MessageID.SyncItem, number: whoAmI.Value);
        }
    }
}