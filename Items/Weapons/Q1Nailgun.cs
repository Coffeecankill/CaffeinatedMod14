using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using CaffinatedMod.Projectiles;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class Q1Nailgun : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Oscillator");
			Tooltip.SetDefault("Increased armor penetration by 5\n'A two-barrel dingus that prickles\nbad guys with armor-piercing darts'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 4;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 64;
			Item.height = 28;
			Item.useTime = 7;
			Item.useAnimation = 7;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 3;
			Item.rare = 2;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 1);
			Item.shootSpeed = 14f;
			Item.useAmmo = AmmoID.Bullet;
			if (!Main.dedServ)
                Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/Q1Nailgun");
		}

        public override void HoldItem(Player player) { 
            player.GetArmorPenetration(DamageClass.Generic) += 5; 
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-2, 1);
        }

		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
		{
			type = ProjectileType<Q1Nail>();

			Vector2 muzzleOffset = Vector2.Normalize(velocity) * 25f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
		}

	}
}