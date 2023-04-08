using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.DataStructures;
using CaffinatedMod.Projectiles;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class CovenantCarbine : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Covenant Carbine");
			Tooltip.SetDefault("'Were it so easy...'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 40;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 58;
			Item.height = 22;
			Item.useTime = 13;
			Item.useAnimation = 13;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 2;
			Item.rare = 4;
			Item.autoReuse = false;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 6);
			Item.shootSpeed = 16f;
			Item.useAmmo = AmmoID.Bullet;
			Item.shoot = ProjectileType<GreenLazer>();
			if (!Main.dedServ) {
                Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/CovenantCarbine");
            }
		}

		public override Vector2? HoldoutOffset()
        {
            return new Vector2(-7, 1);
        }
				
		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback) {
			type = ProjectileType<GreenLazer>();

			Vector2 muzzleOffset = Vector2.Normalize(velocity) * 25f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, -5, 0))
			{
				position += muzzleOffset;
			}
		}
	}
}