using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class Raygun : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Ray Gun");
			Tooltip.SetDefault("'Pack-a-Punch!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 100;
			Item.crit = -4;
			Item.noMelee = true;
			Item.DamageType = DamageClass.Magic;
			Item.channel = true;
			Item.mana = 10;
			Item.width = 68;
			Item.height = 32;
			Item.useTime = 11;
			Item.useAnimation = 11;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.rare = 7;
			Item.autoReuse = false;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 20);
			Item.shoot = ProjectileID.EmeraldBolt;
			Item.shootSpeed = 16f;
			if (!Main.dedServ) {
                Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/Raygun");
            }
		}

        public override Vector2? HoldoutOffset()
        {
			return new Vector2(-6, 1);
        }

		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			player.velocity += new Vector2(-1f * Math.Sign(player.direction), -1f);
			int numberProjectiles = 1 + Main.rand.Next(0);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = velocity.RotatedByRandom(MathHelper.ToRadians(0));
				float scale = 1f - (Main.rand.NextFloat() * 0f);
				perturbedSpeed = perturbedSpeed * scale;
				Projectile.NewProjectile(source, position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
			}
			return false;
		}

		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback) {
			Vector2 muzzleOffset = Vector2.Normalize(velocity) * 25f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
		}
	}
}