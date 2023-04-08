using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace CaffinatedMod.Projectiles
{
	public class RedLaser : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Laser");
		}

		public override void SetDefaults()
		{
			Projectile.CloneDefaults(ProjectileID.GreenLaser);
			AIType = ProjectileID.GreenLaser;
			Projectile.width = 4;
			Projectile.height = 4;
			Projectile.penetrate = 1;
			Projectile.extraUpdates = 10;
			Projectile.friendly = true;
			Projectile.hostile = false;
		}

		public override void Kill(int timeLeft)
		{
			Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
			Terraria.Audio.SoundEngine.PlaySound(SoundID.DD2_LightningAuraZap, Projectile.position);
		}

		public override void AI()
		{
			Projectile.velocity.Y += Projectile.ai[0];
			if (Main.rand.NextBool(1))
			{
				Dust.NewDust(Projectile.position + Projectile.velocity, Projectile.width, Projectile.height, DustID.Flare, Projectile.velocity.X * 0.2f, Projectile.velocity.Y * 0f);
			}
		}
	}
}