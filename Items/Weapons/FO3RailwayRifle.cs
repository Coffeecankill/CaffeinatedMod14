using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class FO3RailwayRifle : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Railway Rifle");
			Tooltip.SetDefault("Increased armor penetration by 15");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 50;
			Item.DamageType = DamageClass.Ranged;
			Item.crit = 16;
			Item.width = 40;
			Item.height = 22;
			Item.useTime = 32;
			Item.useAnimation = 32;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 5;
			Item.rare = 4;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 2);
			Item.shootSpeed = 16f;
			Item.useAmmo = AmmoID.Arrow;
			if (!Main.dedServ) {
                Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/RailwayRifle");
			}
		}

		public override void HoldItem(Player player)
		{
			player.GetArmorPenetration(DamageClass.Generic) += 15;
		}

		public override Vector2? HoldoutOffset()
        {
            return new Vector2(-6, 0);
        }

		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback) {
			Vector2 muzzleOffset = Vector2.Normalize(velocity) * 25f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
		}
	}
}