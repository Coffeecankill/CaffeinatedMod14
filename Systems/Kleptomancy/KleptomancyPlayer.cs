using Terraria;
using Terraria.ModLoader;

namespace CaffinatedMod.Systems.Kleptomancy
{
    public sealed class KleptomancyPlayer : ModPlayer {
    public bool Kleptomancer { get; set; }

    public override void ResetEffects() {
        base.ResetEffects();

        Kleptomancer = false;
    }

    // TODO: These will need to be replaced when porting to 1.4.4!
    public override void OnHitNPC(
        Item item,
        NPC target,
        int damage,
        float knockback,
        bool crit
    ) {
        base.OnHitNPC(item, target, damage, knockback, crit);

        if (Kleptomancer)
            ModContent.GetInstance<KleptomancySystem>().RollKlepto(Player, target);
    }

    public override void OnHitNPCWithProj(
        Projectile proj,
        NPC target,
        int damage,
        float knockback,
        bool crit
    ) {
        base.OnHitNPCWithProj(proj, target, damage, knockback, crit);

        if (Kleptomancer)
            ModContent.GetInstance<KleptomancySystem>().RollKlepto(Player, target);
    }
}
}