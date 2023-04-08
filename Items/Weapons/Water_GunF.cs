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
    public class Water_GunF : ModItem
    {
       public override void SetStaticDefaults() {
			DisplayName.SetDefault("Super Soaker");
			Tooltip.SetDefault("Uses gel for ammo\n'Don't try this at home'");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

		public override void SetDefaults() {
            Item.damage = 25;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 48;
            Item.height = 30;
            Item.useTime = 12;
            Item.useAnimation = 12;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 0f;
            Item.UseSound = SoundID.Item34;
            Item.value = Item.buyPrice(gold: 3);
            Item.rare = 2; 
            Item.autoReuse = true;
			Item.shoot = ProjectileID.Flames;
            Item.shootSpeed = 9f; //This defines the projectile speed when shoot , for flamethrower this make how far the flames can go
            Item.useAmmo = AmmoID.Gel;
        }
		public override Vector2? HoldoutOffset()
        {
            return new Vector2(-6, 0);
        }
        
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.WaterGun, 1);
            recipe.AddIngredient(ItemID.Wire, 4);
            recipe.AddIngredient(ItemID.Gel, 4);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}