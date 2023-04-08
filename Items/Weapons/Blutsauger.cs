using Microsoft.Xna.Framework;
using Terraria.GameContent.Creative;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using CaffinatedMod.Projectiles;
using Terraria.Audio;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class Blutsauger : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Blutsauger");
			Tooltip.SetDefault("On Hit: Gain up to +3 health\nUses Bullets as ammo");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 2;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 44;
			Item.height = 22;
			Item.useTime = 7;
			Item.useAnimation = 7;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 1;
			Item.rare = 1;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 1);
			Item.shootSpeed = 2f;
			Item.useAmmo = AmmoID.Bullet;
			if (!Main.dedServ)
                Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/Blutsauger");
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-3, -2);
        }
				
        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback) {
			type = ProjectileType<Healdart>();
			
			velocity = velocity.RotatedByRandom(MathHelper.ToRadians(05));

			Vector2 muzzleOffset = Vector2.Normalize(velocity) * 40f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
		}
		
		
	}
}