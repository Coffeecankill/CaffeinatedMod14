using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using CaffinatedMod.Projectiles;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class AR2 : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Combine AR2");
			Tooltip.SetDefault("'So thoughtfully provided by Our Benefactors'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 135;
			Item.DamageType = DamageClass.Magic;
			Item.width = 66;
			Item.channel = true;
			Item.mana = 7;
			Item.height = 26;
			Item.useTime = 7;
			Item.useAnimation = 7;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 2;
			Item.rare = 10;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 15);
			Item.shootSpeed = 16f;
			Item.shoot = ProjectileType<PulseBullet>();
			if (!Main.dedServ)
                Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/HL2Pulse");
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-9, 0);
        }

		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
		{
			velocity = velocity.RotatedByRandom(MathHelper.ToRadians(1));
		}
	}
}