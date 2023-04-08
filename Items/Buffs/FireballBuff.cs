using Terraria;
using Terraria.ModLoader;

namespace CaffinatedMod.Items.Buffs
{
	public class FireballBuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fireorange Gumball");
			Description.SetDefault("Immune to lava\n'Citrusy and spicy!'");
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.lavaImmune = true;
			player.fireWalk = true;
		}
	}
}