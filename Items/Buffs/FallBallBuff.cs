using Terraria;
using Terraria.ModLoader;

namespace CaffinatedMod.Items.Buffs
{
	public class FallBallBuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Floatyfruit Gumball");
			Description.SetDefault("You are light as a feather\n'Yup, that tasted purple!'");
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.slowFall = true;
		}
	}
}