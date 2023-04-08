using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class SS2AutoShotgun : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Auto Shotgun");
			Tooltip.SetDefault("8-barreled rotary auto shotgun\n'Sam I am'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 20;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 58;
			Item.height = 32;
			Item.useTime = 60;
			Item.useAnimation = 60;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 4;
			Item.rare = 2;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 4);
			Item.shootSpeed = 6f;
			Item.useAmmo = AmmoID.Bullet;
			if (!Main.dedServ) {
                Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/SS2AutoShotgun");
            }
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(3, 8);
        }
		
		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			int numberProjectiles = 3 + Main.rand.Next(2);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = velocity.RotatedByRandom(MathHelper.ToRadians(1));
				Projectile.NewProjectile(source, position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
			}
			Vector2 muzzleOffset = Vector2.Normalize(velocity) * 35f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return false;
		}
		
	}
}