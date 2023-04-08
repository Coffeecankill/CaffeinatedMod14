using Terraria;
using Terraria.ModLoader;

namespace CaffinatedMod.Items.Buffs
{
	public class SorceryElixorBuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Elixir of Sorcery");
			Description.SetDefault("20% increased magic damage\nIncreased mana regeneration");
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.manaRegenBuff = true;
			player.GetDamage(DamageClass.Magic) += 0.2f;
		}
	}
}