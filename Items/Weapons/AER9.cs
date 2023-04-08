using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using CaffinatedMod.Projectiles;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class AER9 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("AER9 Laser Rifle");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 56;
			Item.height = 18;
			Item.damage = 150;
			Item.DamageType = DamageClass.Magic;
			Item.shoot = ProjectileType<RedLaser>();
			Item.channel = true;
			Item.mana = 8;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.knockBack = 1;
			Item.autoReuse = false;
			Item.rare = 7;
			Item.value = Item.buyPrice(gold: 20);
			Item.shootSpeed = 16f;
			if (!Main.dedServ)
				Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/WazerWifle");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-11, 2);
		}

		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
		{
			type = ProjectileType<RedLaser>();
		}
	}
}