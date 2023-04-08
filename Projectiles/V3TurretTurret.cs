using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using CaffinatedMod.Projectiles;
using CaffinatedMod.Items;
using CaffinatedMod.Items.Tiles;
using Terraria.ObjectData;
using Terraria.Enums;
using static Terraria.ModLoader.ModContent;


namespace CaffinatedMod.Projectiles
{
	public abstract class V3BaseTurret : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			ProjectileID.Sets.MinionTargettingFeature[Projectile.type] = true; //This is necessary for right-click targetting
			ProjectileID.Sets.IsADD2Turret[Projectile.type] = true;
			ProjectileID.Sets.DontAttachHideToAlpha[Projectile.type] = true; // projectiles with hide but without this will draw in the lighting values of the owner player.
		}

        public override void SetDefaults()
        {
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Summon;
			Projectile.friendly = true;
			Projectile.timeLeft = Projectile.SentryLifeTime;
			Projectile.tileCollide = false;
			Projectile.manualDirectionChange = true;
			Projectile.hide = true;
			Projectile.netImportant = true;
			Projectile.penetrate = -1;
			Projectile.sentry = true;
			Projectile.ignoreWater = true;
		}

        public override bool? CanCutTiles()
		{
			return false;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			Projectile.position += Projectile.velocity;
			Projectile.velocity = Vector2.Zero;
			return false;
		}

		public override bool TileCollideStyle(ref int width, ref int height, ref bool fallThrough, ref Vector2 hitboxCenterFrac)
		{
			fallThrough = false;
			return true;
		}

		public override void DrawBehind(int index, List<int> behindNPCsAndTiles, List<int> behindNPCs, List<int> behindProjectiles, List<int> overPlayers, List<int> overWiresUI)
		{
			behindNPCs.Add(index);
		}

		protected float maxRange = 900f;
		protected float projVel = 24f;
		protected float fireRate = 120;
        //protected string turretBase = $"{nameof(ExampleTurret)}/MGTurretBase";
        protected string turretBase = null;
		protected bool wrangler;
		protected int target = -1;
		protected Vector2 baseOffset = Vector2.Zero;
		protected bool reverseDrawOrder = false;

		//Based off of AI_134_Ballista
		public override void AI()
        {
            //float sentrySpeed = Main.player[Projectile.owner].GetModPlayer<CMPlayer>().sentrySpeed;
			Vector2 center = Projectile.Center;
			//On creation
			if (Projectile.ai[0] == 0f)
			{
				Projectile.direction = (Projectile.spriteDirection = Main.player[Projectile.owner].direction);
				Projectile.ai[0] = 1f;
				Projectile.ai[1] = 0f;
				Projectile.netUpdate = true;
				if (Projectile.direction == -1)
				{
					Projectile.rotation = 3.14159274f;
				}
			}
			//Find target
			if (Projectile.ai[0] == 1f)
			{
				target = -1;
				target = this.GetTarget(maxRange, center);
				if (target != -1)
				{
					Vector2 vector = (Main.npc[target].Center - center).SafeNormalize(Vector2.UnitY);
					Projectile.rotation = Projectile.rotation.AngleLerp(vector.ToRotation(), 0.8f);
					if (Projectile.rotation > 1.57079637f || Projectile.rotation < -1.57079637f)
					{
						Projectile.direction = -1;
					}
					else
					{
						Projectile.direction = 1;
					}
					if (Projectile.owner == Main.myPlayer)
					{
						Projectile.direction = Math.Sign(vector.X);
						Projectile.ai[0] = 2f;
						Projectile.ai[1] = 0f;
						Projectile.netUpdate = true;
					}
				}
				else
				{
					float targetAngle = 0f;
					if (Projectile.direction == -1)
						targetAngle = 3.14159274f;
					Projectile.rotation = Projectile.rotation.AngleLerp(targetAngle, 0.05f);
				}
			}
			//Prepare to fire
			if (Projectile.ai[0] == 2f)
			{
				Projectile.ai[1]++;
				if (Projectile.ai[1] >= fireRate)
				{
					Vector2 vector2 = new Vector2((float)Projectile.direction, 0f);
					int target2 = GetTarget(maxRange, center);
					if (target2 != -1)
					{
						vector2 = (Main.npc[target2].Center - center).SafeNormalize(Vector2.UnitX * (float)Projectile.direction);
					}
					Projectile.rotation = vector2.ToRotation();
					if (Projectile.rotation > 1.57079637f || Projectile.rotation < -1.57079637f)
					{
						Projectile.direction = -1;
					}
					else
					{
						Projectile.direction = 1;
					}
					if (Projectile.owner == Main.myPlayer)
					{
						Fire(null, vector2, target2);
					}
					Projectile.ai[0] = 1f;
					Projectile.ai[1] = 0f;
				}
			}
			Projectile.spriteDirection = Projectile.direction;
			Projectile.tileCollide = true;
			Projectile.velocity.Y = Projectile.velocity.Y + 0.2f;
		}

		/*public new void FloatEffect()
		{
			if (!canFloat && Main.player[Projectile.owner].GetModPlayer<CMPlayer>().floatingTurrets)
			{
				for (int i = -1; i < 2; i++)
				{
					if (i != 0)
					{
						int floatDust = Dust.NewDust(Projectile.Center, 0, 0, 226, 0f, 0f, 100, default(Color), 0.5f);
						Main.dust[floatDust].noGravity = true;
						Main.dust[floatDust].velocity.X = (Projectile.width / 20f) * i;
						Main.dust[floatDust].velocity.Y = 0;
						Main.dust[floatDust].noLight = true;
						Main.dust[floatDust].position.X = Projectile.Center.X;
						Main.dust[floatDust].position.Y = Projectile.position.Y + Projectile.height;
					}
				}
			}
		}*/

		//Draw the turret base
		/*public override bool PreDrawExtras()
		{
			if (turretBase == null)
				return false;
			Texture2D texture = ModContent.Request<Texture2D>(turretBase, AssetRequestMode.ImmediateLoad).Value;
			Microsoft.Xna.Framework.Color color25 = Lighting.GetColor((int)((double)Projectile.position.X + (double)Projectile.width * 0.5) / 16, (int)(((double)Projectile.position.Y + (double)Projectile.height * 0.5) / 16.0));
			Vector2 basePos = texture.Size() * new Vector2(0.5f, 1f);
			basePos.Y -= 2f;
			Vector2 drawPos = Projectile.Bottom + Vector2.UnitY * Projectile.gfxOffY - Main.screenPosition + baseOffset;
			SpriteEffects spriteEffects = SpriteEffects.None;
			Main.spriteBatch.Draw(texture, drawPos, null, Projectile.GetAlpha(color25), 0f, basePos, 1f, spriteEffects & SpriteEffects.FlipHorizontally, 0f);
			return true;
		}*/

		//Make the turret itself rotate
		public override bool PreDraw(ref Color lightColor)
		{
			if (reverseDrawOrder)
			{
				DrawTurret(ref lightColor);
                DrawTurretBase(ref lightColor);
            }
            else
            {
                DrawTurretBase(ref lightColor);
                DrawTurret(ref lightColor);
            }
			return false;
        }

		public void DrawTurret(ref Color lightColor)
        {
            SpriteEffects spriteEffects = SpriteEffects.None;
            if (Projectile.spriteDirection == -1)
            {
                spriteEffects = SpriteEffects.FlipVertically;
            }
            Vector2 drawOrigin = new(TextureAssets.Projectile[Projectile.type].Value.Width * 0.5f, Projectile.height * 0.5f);
            for (int k = 0; k < Projectile.oldPos.Length; k++)
            {
                Vector2 drawPos = Projectile.Center - Main.screenPosition;
                Color color = Projectile.GetAlpha(lightColor) * ((float)(Projectile.oldPos.Length - k) / (float)Projectile.oldPos.Length);
                Main.spriteBatch.Draw(TextureAssets.Projectile[Projectile.type].Value, drawPos, null, color, Projectile.rotation, drawOrigin, Projectile.scale, spriteEffects, 0f);
            }
        }

        public void DrawTurretBase(ref Color lightColor)
        {
			if (turretBase != null)
			{
				Texture2D texture = ModContent.Request<Texture2D>(turretBase, AssetRequestMode.ImmediateLoad).Value;
				Vector2 basePos = texture.Size() * new Vector2(0.5f, 1f);
				basePos.Y -= 2f;
				Vector2 drawPos2 = Projectile.Bottom + Vector2.UnitY * Projectile.gfxOffY - Main.screenPosition + baseOffset;
				SpriteEffects spriteEffects2 = SpriteEffects.None;
				Main.spriteBatch.Draw(texture, drawPos2, null, lightColor, 0f, basePos, 1f, spriteEffects2 & SpriteEffects.FlipHorizontally, 0f);
			}
        }

        public virtual void Fire(EntitySource_ItemUse_WithAmmo source, Vector2 vector2, int target = -1)
		{
		}

		public int GetTarget(float maxRange, Vector2 shootingSpot)
		{
			int first = -1;
			//maxRange *= Main.player[Projectile.owner].GetModPlayer<CMPlayer>().sentryRange;
			NPC ownerMinionAttackTargetNPC = Projectile.OwnerMinionAttackTargetNPC;
			if (ownerMinionAttackTargetNPC != null && ownerMinionAttackTargetNPC.CanBeChasedBy(this, false))
			{
				for (int i = 0; i < 1; i++)
				{
					if (ownerMinionAttackTargetNPC.CanBeChasedBy(this, true))
					{
						float distance = Vector2.Distance(shootingSpot, ownerMinionAttackTargetNPC.Center);
						if (distance <= maxRange)
						{
							Vector2 vector = (ownerMinionAttackTargetNPC.Center - shootingSpot).SafeNormalize(Vector2.UnitY);
							if ((Math.Abs(vector.X) >= 0 || vector.Y <= 0f) && (first == -1 || distance < Vector2.Distance(shootingSpot, Main.npc[first].Center)) && Collision.CanHitLine(shootingSpot, 0, 0, ownerMinionAttackTargetNPC.Center, 0, 0))
							{
								first = ownerMinionAttackTargetNPC.whoAmI;
							}
						}
					}
				}
				if (first != -1)
				{
					return first;
				}
			}
			for (int j = 0; j < 200; j++)
			{
				NPC nPC = Main.npc[j];
				if (nPC.CanBeChasedBy(this, false))
				{
					float distance2 = Vector2.Distance(shootingSpot, nPC.Center);
					if (distance2 <= maxRange)
					{
						Vector2 vector2 = (nPC.Center - shootingSpot).SafeNormalize(Vector2.UnitY);
						if ((Math.Abs(vector2.X) >= 0 || vector2.Y <= 0f) && (first == -1 || distance2 < Vector2.Distance(shootingSpot, Main.npc[first].Center)) && Collision.CanHitLine(shootingSpot, 0, 0, nPC.Center, 0, 0))
						{
							first = j;
						}
					}
				}
			}
			return first;
		}

		public override bool? CanHitNPC(NPC npc)
		{
			return false;
		}
    }

	public class V3TurretTurret : BaseTurret
	{
		public override void SetDefaults()
		{
			base.SetDefaults();
			Projectile.width = 66;
			Projectile.height = 24;
			fireRate = 40;
			maxRange = 1200f;
			turretBase = $"{nameof(CaffinatedMod)}/Projectiles/V3TurretBase";
			baseOffset.Y = 42;
			reverseDrawOrder = true;

        }

		public override void Fire(EntitySource_ItemUse_WithAmmo source, Vector2 vector2, int target)
		{
			Vector2 velocity = vector2 * projVel;
			Vector2 center = Projectile.Center;
			//SoundEngine.PlaySound(new SoundStyle("CaffinatedMod/Sounds/Custom/Machinegun"));
			SoundEngine.PlaySound(SoundID.Item115, Projectile.position);
			Projectile.NewProjectile(source, center, velocity, Mod.Find<ModProjectile>("V3TurretTurretProj").Type, Projectile.damage, Projectile.knockBack, Projectile.owner, 0f, 0f);
        }

        public override bool TileCollideStyle(ref int width, ref int height, ref bool fallThrough, ref Vector2 hitboxCenterFrac)
        {
			height = 102;
			fallThrough = false;
            return true;
        }
	}

	public class V3TurretTurretProj : ModProjectile
    {
        public override string Texture
        {
            get
            {
				return "Terraria/Images/Projectile_876";
			}
        }

        public override void SetStaticDefaults()
        {
            ProjectileID.Sets.SentryShot[Projectile.type] = true;
        }

        public override void SetDefaults()
        {
			Projectile.CloneDefaults(14);
			AIType = ProjectileID.Bullet;
			Projectile.width = 4;
            Projectile.height = 4;
            Projectile.extraUpdates = 10;
            Projectile.localNPCHitCooldown = -1;
            Projectile.usesLocalNPCImmunity = true;
            Projectile.timeLeft = 180;
        }
    }

    public class V3TurretItem : ModItem
    {
        public override string Texture => Mod.Name + "/Projectiles/V3TurretTurret2";
		int yPlace = -51;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pulse Turret Remote");
			Tooltip.SetDefault("Summons a pulse turret that attacks enemies\n'Large Marge; eats cultists for breakfast...'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            ItemID.Sets.GamepadWholeScreenUseRange[Item.type] = true; // This lets the player target anywhere on the whole screen while using a controller
            ItemID.Sets.LockOnIgnoresCollision[Item.type] = true;
        }

        public override void SetDefaults()
        {
            Item.maxStack = 1;
			Item.DamageType = DamageClass.Summon;
            Item.sentry = true;
            Item.DD2Summon = true;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.UseSound = SoundID.DD2_DefenseTowerSpawn;
            Item.useTurn = true;
            Item.noMelee = true;
            Item.damage = 200;
            Item.width = 14;
            Item.height = 24;
            Item.knockBack = 5f;
			Item.rare = ItemRarityID.Red;
			Item.value = Item.sellPrice(silver: 450);
			Item.shoot = Mod.Find<ModProjectile>("V3TurretTurret").Type;
        }

        public override bool AltFunctionUse(Player player)
        {
			return true;
        }

        public override bool? UseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                player.MinionNPCTargetAim(true);
            }
            return base.UseItem(player);
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            position = Main.MouseWorld;
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            if (player.altFunctionUse == 2)
			return false;
            int xx = (int)((float)Main.mouseX + Main.screenPosition.X) / 16;
            int yy = (int)((float)Main.mouseY + Main.screenPosition.Y) / 16;
            int bump = -16;
            if (player.gravDir == -1f)
            {
                yy = (int)(Main.screenPosition.Y + (float)Main.screenHeight - (float)Main.mouseY) / 16;
            }
            player.FindSentryRestingSpot(Item.shoot, out xx, out yy, out bump);
            var projectile = Projectile.NewProjectileDirect(source, new Vector2(xx, yy + yPlace), Vector2.Zero, type, damage, knockback, Main.myPlayer);
            projectile.originalDamage = Item.damage;
            //if (!DD2Event.Ongoing)
                player.UpdateMaxTurrets();
            return false;
        }

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<DreamBar>(14)
				.AddIngredient(ItemID.FragmentStardust, 18)
				.AddTile(TileID.Anvils)
				.Register();

			CreateRecipe()
				.AddIngredient<MGTurretItem>(1)
				.AddIngredient(ItemID.FragmentStardust, 18)
				.AddTile(TileID.Anvils)
				.Register();

			CreateRecipe()
				.AddIngredient<V2TurretItem>(1)
				.AddIngredient(ItemID.FragmentStardust, 18)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
