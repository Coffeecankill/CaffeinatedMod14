using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent;

namespace CaffinatedMod.Items.Buffs
{
	public class CleanseBuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cleansed");
			Description.SetDefault("Debuffs removed!'");
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.buffImmune[20] = true;
			player.buffImmune[21] = true;
			player.buffImmune[22] = true;
			player.buffImmune[23] = true;
			player.buffImmune[24] = true;
			player.buffImmune[25] = true;
			player.buffImmune[30] = true;
			player.buffImmune[31] = true;
			player.buffImmune[32] = true;
			player.buffImmune[33] = true;
			player.buffImmune[35] = true;
			player.buffImmune[36] = true;
			player.buffImmune[37] = true;
			player.buffImmune[39] = true;
			player.buffImmune[44] = true;
			player.buffImmune[46] = true;
			player.buffImmune[47] = true;
			player.buffImmune[67] = true;
			player.buffImmune[68] = true;
			player.buffImmune[69] = true;
			player.buffImmune[70] = true;
			player.buffImmune[80] = true;
			player.buffImmune[94] = true;
			player.buffImmune[144] = true;
			player.buffImmune[148] = true;
			player.buffImmune[149] = true;
			player.buffImmune[156] = true;
			player.buffImmune[163] = true;
			player.buffImmune[164] = true;
			player.buffImmune[195] = true;
			player.buffImmune[196] = true;
			player.buffImmune[197] = true;
			player.buffImmune[203] = true;
		}
	}
}