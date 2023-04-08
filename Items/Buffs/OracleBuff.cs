using Terraria;
using Terraria.ModLoader;

namespace CaffinatedMod.Items.Buffs
{
	public class OracleBuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Oracle's Extract");
			Description.SetDefault("Shows the location of enemies\nYou can see nearby hazards");
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.dangerSense = true;
			player.detectCreature = true;
		}
	}
}