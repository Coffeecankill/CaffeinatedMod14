using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Terraria.ID;

namespace CaffinatedMod.Items.Letters
{
	public class LostLetter : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Lost Letter");
			Tooltip.SetDefault("Can be redeemed at the Mysterious Mailbox");
		}

		public override void SetDefaults() {
			Item.width = 22;
			Item.height = 12;
			Item.maxStack = 99;
			Item.rare = ItemRarityID.Blue;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.value = Item.buyPrice(gold: 1);
		}
    }
	/*
	public class LostLetterDropLogic : GlobalNPC
	{
		public override void ModifyGlobalLoot(GlobalLoot globalLoot) {
			base.ModifyGlobalLoot(globalLoot);

			// 1/250 = 0.4% chance
			globalLoot.Add(ItemDropRule.Common(ModContent.ItemType<LostLetter>(), 250));
		}
	*/
	// This is for adding drops to single NPCs.
	/*public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot) {
		base.ModifyNPCLoot(npc, npcLoot);

		// If the NPC is a blue slime.
		if (npc.type == NPCID.BlueSlime) {
			// Drop 10-20 dirt blocks with a 1/1 chance.
			npcLoot.Add(ItemDropRule.Common(ItemID.DirtBlock, 1, 10, 20));
		}
	}*/
}