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
	public class KSMG : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("K-SMG");
			Tooltip.SetDefault("Shoots a powerful, high velocity bullet\n'Custom built SMG'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.damage = 26;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 64;
			Item.height = 32;
			Item.useTime = 9;
			Item.useAnimation = 9;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 4;
			Item.rare = 4;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 30);
			Item.shootSpeed = 16f;
			Item.useAmmo = AmmoID.Bullet;
			if (!Main.dedServ)
				Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/KSMG");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(3, 0);
		}

		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
		{
			if (type == ProjectileID.Bullet)
			{
				type = ProjectileID.BulletHighVelocity;
			}
		}
	}
}