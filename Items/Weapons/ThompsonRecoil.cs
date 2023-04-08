using Microsoft.Xna.Framework;
using Terraria.GameContent.Creative;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using CaffinatedMod.Projectiles;
using Terraria.Audio;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class ThompsonRecoil : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Thompson");
			Tooltip.SetDefault("Can be upgraded\n'A stabilization cylinder reduces the kickback'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.damage = 25;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 80;
			Item.height = 26;
			Item.useTime = 8;
			Item.useAnimation = 8;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 3;
			Item.rare = 5;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 40);
			Item.shootSpeed = 9f;
			Item.UseSound = SoundID.Item41;
			Item.useAmmo = AmmoID.Bullet;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-24, 3);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IllegalGunParts, 1);
			recipe.AddIngredient(Mod.Find<ModItem>("Thompson").Type);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}