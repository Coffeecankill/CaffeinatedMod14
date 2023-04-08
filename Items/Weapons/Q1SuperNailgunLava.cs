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
	public class Q1SuperNailgunLava : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Lava Perforator");
			Tooltip.SetDefault("Increased armor penetration by 10\n'Now fires superheated projectiles!'");
		}

		public override void SetDefaults() {
			Item.damage = 25;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 67;
			Item.height = 26;
			Item.useTime = 7;
			Item.useAnimation = 7;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 1;
			Item.rare = 5;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 12);
			Item.shootSpeed = 5f;
			Item.useAmmo = AmmoID.Bullet;
			Item.shoot = ProjectileType<FireBullet>();
            if (!Main.dedServ)
                Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/Q1SuperNailgunLava");
		}

        public override void HoldItem(Player player) { 
            player.GetArmorPenetration(DamageClass.Generic) += 10; 
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(3, 0);
        }
				
        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback) {
			type = ProjectileType<FireBullet>();
			
			Vector2 muzzleOffset = Vector2.Normalize(velocity) * 40f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.HellstoneBar, 20);
			recipe.AddIngredient(Mod.Find<ModItem>("Q1SuperNailgun").Type);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}
*/