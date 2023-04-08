using Terraria;
using Terraria.ModLoader;

namespace CaffinatedMod.Items.Buffs
{
	public class HealthballBuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heartberry Gumball");
			Description.SetDefault("+20 increased max life\n'Full of flavor!'");
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.statLifeMax2 += 20;
		}
	}
}