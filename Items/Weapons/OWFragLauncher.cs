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
	public class OWFragLauncher : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Frag Launcher");
			Tooltip.SetDefault("Uses rockets as ammo\nDoes closer to 50 damage\n'If at first you don't\nsucceed... Blow it up again!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 10;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 66;
			Item.height = 20;
			Item.useTime = 35;
			Item.useAnimation = 35;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 3;
			Item.rare = 2;
			Item.autoReuse = true;
			Item.value = Item.buyPrice(gold: 5);
			Item.shootSpeed = 12f;
			Item.useAmmo = AmmoID.Rocket;
			Item.shoot = ProjectileID.GrenadeI;
			if (!Main.dedServ) {
                Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/OWFragLauncher")
                {
	                PitchVariance = .175f
                };
            }
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-25, -9);
        }
				
        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback) {
			Vector2 muzzleOffset = Vector2.Normalize(velocity) * 75f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
		}
	}
}