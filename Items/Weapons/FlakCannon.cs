using Microsoft.Xna.Framework;
using System;
using Terraria.GameContent.Creative;
using Terraria;
using CaffinatedMod.Projectiles;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class FlakCannon : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Maribelle");
			Tooltip.SetDefault("'Consumes arrows and fires a massive\nvolley of molten flak at enemies'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 16;
			Item.DamageType = DamageClass.Ranged;
			Item.crit = 6;
			Item.width = 56;
			Item.height = 18;
			Item.useTime = 90;
			Item.useAnimation = 90;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 10;
			Item.rare = 4;
			Item.UseSound = SoundID.Item14;
			Item.autoReuse = false;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 40);
			Item.shootSpeed = 6f;
			Item.useAmmo = AmmoID.Arrow;
			Item.shoot = ProjectileType<FireBullet>();
		}

		public override void HoldItem(Player player)
		{
			player.GetArmorPenetration(DamageClass.Generic) += 5;
		}

		public override Vector2? HoldoutOffset()
        {
            return new Vector2(-11, -6);
        }

		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			//type = ProjectileID.MeteorShot;
			type = ProjectileType<FireBullet>();
			int numberProjectiles = 15 + Main.rand.Next(0);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = velocity.RotatedByRandom(MathHelper.ToRadians(16));
				float scale = 1f - (Main.rand.NextFloat() * .2f);
				perturbedSpeed = perturbedSpeed * scale;
				Projectile.NewProjectile(source, position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
			}
			return false;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldCoin, 25);
			recipe.AddTile(null, "VendingMachineTileV3");
			recipe.Register();
		}
	}
}