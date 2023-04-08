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
	public class MK420 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Not-So-Smart Pistol Mk.420");
			Tooltip.SetDefault("Shoots a homing bullet\n'Is this pistol smarter than me?'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.PhoenixBlaster);
			Item.damage = 16;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.knockBack = 2;
			Item.value = Item.buyPrice(gold: 15);
			Item.rare = 1;
			Item.shootSpeed = 9f;
			if (!Main.dedServ)
				Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/MK420");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}

		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
		{
			if (type == ProjectileID.Bullet)
			{
				type = ProjectileID.ChlorophyteBullet;
			}
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldCoin, 12);
			recipe.AddTile(null, "VendingMachineTileV2");
			recipe.Register();
		}
	}
}