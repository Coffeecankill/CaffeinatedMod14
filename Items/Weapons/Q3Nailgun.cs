using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using CaffinatedMod.Projectiles;
using Terraria.GameContent.Creative;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class Q3Nailgun : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Spiker");
			Tooltip.SetDefault("Fires a spread of nails\nBenefits from melee modifiers\n'Elder Gods approved'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 32;
			Item.DamageType = DamageClass.Melee;
			Item.width = 72;
			Item.height = 30;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 6;
			Item.rare = 7;
			Item.autoReuse = false;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 20);
			Item.shootSpeed = 12f;
			//Item.shoot = ProjectileID.MeteorShot;
			Item.shoot = ProjectileType<Nail2>();
			Item.useAmmo = AmmoID.Bullet;
			if (!Main.dedServ)
				Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/NailShotty");
		}

		public override Vector2? HoldoutOffset()
        {
            return new Vector2(-16, 2);
        }

		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			//type = ProjectileID.MeteorShot;
			type = ProjectileType<Nail2>();
			int numberProjectiles = 5 + Main.rand.Next(2);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = velocity.RotatedByRandom(MathHelper.ToRadians(6));
				float scale = 1f - (Main.rand.NextFloat() * .2f);
				perturbedSpeed = perturbedSpeed * scale;
				Projectile.NewProjectile(source, position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
			}
			return false;
		}
	}
}