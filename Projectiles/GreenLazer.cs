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
	public class GreenLazer : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Green Laser");
		}

		public override void SetDefaults()
		{
			Projectile.CloneDefaults(ProjectileID.GreenLaser);
			AIType = ProjectileID.GreenLaser;
			Projectile.width = 4;
			Projectile.height = 4;
			Projectile.penetrate = 1;
			Projectile.extraUpdates = 2;
			Projectile.friendly = true;
			Projectile.hostile = false;
		}

		public override void Kill(int timeLeft)
		{
			Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
			Terraria.Audio.SoundEngine.PlaySound(SoundID.DD2_LightningAuraZap, Projectile.position);
		}
	}
}