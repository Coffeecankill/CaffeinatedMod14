using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CaffinatedMod.Items.Weapons
{
    public class BicFlamer : ModItem
    {
       public override void SetStaticDefaults() {
			DisplayName.SetDefault("ThiC Lighter");
			Tooltip.SetDefault("'Ouch!'");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

		public override void SetDefaults() {
            Item.damage = 35;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 50;
            Item.height = 18;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 20;
            //Item.UseSound = SoundID.Item34;
            Item.value = Item.buyPrice(gold: 1);
            Item.rare = 3; 
            Item.autoReuse = true;
			Item.shoot = ProjectileID.Flames;
            Item.shootSpeed = 1f; //This defines the projectile speed when shoot , for flamethrower this make how far the flames can go
            if (!Main.dedServ)
                Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/Flick");
        }

		public override Vector2? HoldoutOffset()
        {
            return new Vector2(-15, 6);
        }
    }
}