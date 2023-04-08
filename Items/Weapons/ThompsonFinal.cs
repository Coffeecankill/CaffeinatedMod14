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
	public class ThompsonFinal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Thompson");
			Tooltip.SetDefault("'A fully upgraded Thompson SMG'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.damage = 31;
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
			Item.value = Item.buyPrice(gold: 50);
			Item.shootSpeed = 16f;
			Item.UseSound = SoundID.Item41;
			Item.useAmmo = AmmoID.Bullet;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-24, 3);
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.IllegalGunParts, 1)
				.AddIngredient(null, "ThompsonRecoil")
				.AddTile(TileID.Anvils)
				.Register();

			CreateRecipe()
				.AddIngredient(ItemID.IllegalGunParts, 1)
				.AddIngredient(null, "ThompsonD")
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}