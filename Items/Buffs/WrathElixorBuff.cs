using Terraria;
using Terraria.ModLoader;

namespace CaffinatedMod.Items.Buffs
{
	public class WrathElixorBuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Elixir of Wrath");
			Description.SetDefault("15% increased melee/ranged damage\nGreatly increased life regen");
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.GetDamage(DamageClass.Ranged) += 0.15f;
			player.GetDamage(DamageClass.Melee) += 0.15f;
			player.lifeRegen += 6;
		}
	}
}