using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CaffinatedMod.Items.Weapons
{
    public class CaulkNBurn : ModItem
    {
       public override void SetStaticDefaults() {
			DisplayName.SetDefault("Caulk n' Burn");
			Tooltip.SetDefault("Uses gel for ammo\n'Hand-held, home-made flamethrower.\nHeavy damage at the cost of range.'\n'Barbecue tonight?'");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

		public override void SetDefaults() {
            Item.damage = 18;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 78;
            Item.height = 28;
            Item.useTime = 13;
            Item.useAnimation = 10;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 1f;
            Item.UseSound = SoundID.Item34;
            Item.value = Item.buyPrice(silver: 50);
            Item.rare = 2; 
            Item.autoReuse = true;
			Item.shoot = ProjectileID.Flames;
            Item.shootSpeed = 1.5f; //This defines the projectile speed when shoot , for flamethrower this make how far the flames can go
            Item.useAmmo = AmmoID.Gel;
        }
		public override Vector2? HoldoutOffset()
        {
            return new Vector2(-15, -2);
        }
		
		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback) {
			Vector2 muzzleOffset = Vector2.Normalize(velocity) * 46f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
		}
    }
}