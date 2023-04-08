using Terraria;
using Terraria.ModLoader;

namespace CaffinatedMod.Items.Buffs
{
	public class RogueBuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Potion of Rouge");
			Description.SetDefault("10% increased damage");
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.GetDamage(DamageClass.Generic) += 0.10f;
		}
	}
}