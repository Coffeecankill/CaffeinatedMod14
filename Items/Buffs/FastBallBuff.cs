using Terraria;
using Terraria.ModLoader;

namespace CaffinatedMod.Items.Buffs
{
	public class FastBallBuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hypersugar Gumball");
			Description.SetDefault("12% increased melee and mining speed\n'Sugary Sweet!'");
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.pickSpeed -= 0.12f;
			player.GetAttackSpeed(DamageClass.Melee) += 0.12f;
		}
	}
}