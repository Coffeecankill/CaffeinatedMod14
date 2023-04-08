using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using CaffinatedMod.Items.Accessories;
using CaffinatedMod.Items.Letters;
using CaffinatedMod.Items.Weapons;
using CaffinatedMod.Items;
using System.Linq;

namespace CaffinatedMod.CaffinatedNPCLoot
{
	public class CaffinatedNPCLoot : GlobalNPC
	{
		public class LostLetterDropLogic : GlobalNPC
		{
			public override void ModifyGlobalLoot(GlobalLoot globalLoot)
			{
				base.ModifyGlobalLoot(globalLoot);

				// 1/250 = 0.4% chance
				globalLoot.Add(ItemDropRule.Common(ModContent.ItemType<LostLetter>(), 250));
			}
		}
		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
		{
			base.ModifyNPCLoot(npc, npcLoot);
			if (npc.type == NPCID.MisterStabby)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LargeSpoon>(), 50));
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GiantToothbrush>(), 50));
			}
			if (npc.type == NPCID.SnowmanGangsta)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MP40>(), 50));
			}
			if (npc.type == NPCID.Golem)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ReaperInvoice>(), 8));
			}
			if (npc.type == NPCID.Plantera)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<AER9Invoice>(), 7));
			}
			if (npc.type == NPCID.SporeSkeleton)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<StinkyCheese>(), 15));
			}
			if (npc.type == NPCID.SporeBat)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<StinkyCheese>(), 15));
			}
			if (npc.type == NPCID.LavaSlime)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BicFlamer>(), 20));
			}
			if (npc.type == NPCID.Unicorn)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Tootba>(), 50));
			}
			if (npc.type == NPCID.UndeadViking)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<NordGreatsword>(), 25));
			}
			if (npc.type == NPCID.SnowFlinx)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Snowblower>(), 20));
			}
			if (npc.type == NPCID.GiantTortoise)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<WumpaFruit>(), 10));
			}
		}
	}
}