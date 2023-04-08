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
	public class YellowLaser : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Yellow Laser");
			ProjectileID.Sets.TrailCacheLength[Projectile.type] = 1;
			ProjectileID.Sets.TrailingMode[Projectile.type] = 1;
		}

		public override void SetDefaults()
		{
			Projectile.CloneDefaults(ProjectileID.GreenLaser);
			AIType = ProjectileID.GreenLaser;
			Projectile.width = 8;
			Projectile.height = 8;
			Projectile.penetrate = 1;
			Projectile.extraUpdates = 2;
			Projectile.alpha = 150;
			Projectile.light = 0.5f;
			Projectile.friendly = true;
			Projectile.hostile = false;
		}

		public override void PostAI()
		{
			if (Main.rand.NextBool(3))
			{
				Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.Torch); // Makes the projectile emit dust.
			}
		}

		public override void Kill(int timeLeft)
		{
			Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
			Terraria.Audio.SoundEngine.PlaySound(SoundID.DD2_LightningAuraZap, Projectile.position);
		}
	}
}