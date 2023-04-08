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
    public class Slime_GunF : ModItem
    {
       public override void SetStaticDefaults() {
			DisplayName.SetDefault("Flamespitter");
			Tooltip.SetDefault("Uses gel for ammo\n'Squirts a harmful stream of fire'");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

		public override void SetDefaults() {
            Item.damage = 35;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 44;
            Item.height = 26;
            Item.useTime = 45;
            Item.useAnimation = 45;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 1f;
            Item.UseSound = SoundID.Item34;
            Item.value = Item.buyPrice(gold: 1);
            Item.rare = 2; 
            Item.autoReuse = true;
			Item.shoot = ProjectileID.Flames;
            Item.shootSpeed = 6f; //This defines the projectile speed when shoot , for flamethrower this make how far the flames can go
            Item.useAmmo = AmmoID.Gel;
        }

		public override Vector2? HoldoutOffset()
        {
            return new Vector2(-7, -3);
        }
        
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SlimeGun, 1);
            recipe.AddRecipeGroup("IronBar", 15);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}