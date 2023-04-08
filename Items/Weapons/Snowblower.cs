using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using CaffinatedMod.Projectiles;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class Snowblower : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Snowblower Gun");
			Tooltip.SetDefault("'Half snowblower, half shotgun, all awesome!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 10;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 60;
			Item.height = 22;
			Item.useTime = 40;
			Item.useAnimation = 40;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 5;
			Item.rare = 1;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.value = Item.buyPrice(silver: 50);
			Item.shootSpeed = 11;
			Item.UseSound = SoundID.Item23;
			Item.useAmmo = AmmoID.Snowball;
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-7, 0);
        }
		
		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			type = ProjectileType<ShottyBall>();
			float numberProjectiles = 3 + Main.rand.Next(0);
			float rotation = MathHelper.ToRadians(10);
			position += Vector2.Normalize(velocity) * 45f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = velocity.RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 2f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(source, position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
			}
			return false;
		}
	}
}