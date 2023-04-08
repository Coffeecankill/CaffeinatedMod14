using Microsoft.Xna.Framework;
using Terraria.GameContent.Creative;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class JinxRL : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Ambitious Elf Giftbones");
			Tooltip.SetDefault("Uses rockets as ammo\nDoes closer to 90 damage\n'Fishbones actually just\nwants to help people.'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.damage = 1;
			Item.crit = -4;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 60;
			Item.height = 30;
			Item.useTime = 55;
			Item.useAnimation = 55;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 5;
			Item.rare = 2;
			Item.autoReuse = false;
			Item.value = Item.buyPrice(gold: 2);
			Item.shootSpeed = 12f;
			//Item.UseSound = SoundID.Item61;
			Item.useAmmo = AmmoID.Rocket;
			Item.shoot = ProjectileID.RocketI;
			if (!Main.dedServ)
			{
				Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/JinxRocket")
				{
					PitchVariance = .2f
				};
			}

		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-25, -8);
        }
				
        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback) {
			Vector2 muzzleOffset = Vector2.Normalize(velocity) * 42f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
		}
	}
}