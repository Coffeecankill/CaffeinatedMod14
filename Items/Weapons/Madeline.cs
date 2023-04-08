using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class Madeline : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Madeline");
			Tooltip.SetDefault("4-Gauge Shotgun");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 8;
			Item.crit = 6;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 56;
			Item.height = 18;
			Item.useTime = 90;
			Item.useAnimation = 90;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 16;
			Item.rare = 2;
			Item.UseSound = SoundID.Item14;
			Item.autoReuse = false;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 30);
			Item.shootSpeed = 6f;
			Item.useAmmo = AmmoID.Bullet;
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-9, 0);
        }
		
		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			player.velocity += new Vector2(-16f * Math.Sign(player.direction), -3f);
			int numberProjectiles = 20 + Main.rand.Next(0);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = velocity.RotatedByRandom(MathHelper.ToRadians(25));
				float scale = 1f - (Main.rand.NextFloat() * .3f);
				perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(source, position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
			}
			return false;
		}
		
        public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.GoldCoin, 25);
            recipe.AddTile(null, "VendingMachineTileV2");
            recipe.Register();
		}
	}
}