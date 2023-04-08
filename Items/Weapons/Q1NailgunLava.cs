/*
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using CaffinatedMod.Projectiles;
using Terraria.Audio;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class Q1NailgunLava : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Lava Oscillator");
			Tooltip.SetDefault("Increased armor penetration by 5\n'Now fires superheated projectiles!'");
		}

		public override void SetDefaults() {
			Item.damage = 8;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 64;
			Item.height = 28;
			Item.useTime = 7;
			Item.useAnimation = 7;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 1;
			Item.rare = 3;
			Item.autoReuse = true;
			Item.value = Item.buyPrice(gold: 2);
			Item.shootSpeed = 5f;
            Item.shoot = 10;
			Item.useAmmo = AmmoID.Bullet;
			Item.shoot = ProjectileType<FireBullet>();
            if (!Main.dedServ)
                Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/Q1NailgunLava");
		}

        public override void HoldItem(Player player) { 
            player.GetArmorPenetration(DamageClass.Generic) += 5; 
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-2, 1);
        }
				
        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback) {
			type = ProjectileType<FireBullet>();
			
			Vector2 muzzleOffset = Vector2.Normalize(velocity) * 25f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddIngredient(Mod.Find<ModItem>("Q1Nailgun").Type);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}
*/