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
    public class Putrifier : ModItem
    {
       public override void SetStaticDefaults() {
			DisplayName.SetDefault("Chemtech Putrifier");
			Tooltip.SetDefault("Uses gel for ammo\n'Puffcap Perfection'");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

		public override void SetDefaults() {
            Item.damage = 90;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 44;
            Item.height = 24;
            Item.useTime = 45;
            Item.useAnimation = 45;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 7f;
            Item.UseSound = SoundID.Item34;
            Item.value = Item.buyPrice(gold: 10);
            Item.rare = 4; 
            Item.autoReuse = true;
			Item.shoot = ProjectileID.CursedFlameFriendly;
            Item.shootSpeed = 16f;
            Item.useAmmo = AmmoID.Gel;
        }
		public override Vector2? HoldoutOffset()
        {
            return new Vector2(-6, 0);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.GoldCoin, 10);
            recipe.AddTile(null, "VendingMachineTileV3");
            recipe.Register();
        }
    }
}