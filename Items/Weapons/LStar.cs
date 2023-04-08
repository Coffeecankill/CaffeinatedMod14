using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class LStar : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("L-Star");
			Tooltip.SetDefault("'Remember 7274! is \nengraved onto the stock'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 32;
			Item.DamageType = DamageClass.Magic;
			Item.channel = true;
			Item.mana = 6;
			Item.width = 78;
			Item.height = 32;
			Item.useTime = 6;
			Item.useAnimation = 6;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 3;
			Item.rare = 7;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 20);
			Item.shootSpeed = 16f;
			Item.shoot = ProjectileID.SapphireBolt;
			if (!Main.dedServ) {
				Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/LStar");
            }
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-18, 2);
        }
		/*		
        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback) {
			Vector2 muzzleOffset = Vector2.Normalize(velocity) * 25f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, -20, 8))
			{
				position += muzzleOffset;
			}
		*/
		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
		{
			velocity = velocity.RotatedByRandom(MathHelper.ToRadians(2));
		}
	}
}