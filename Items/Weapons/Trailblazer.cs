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
	public class Trailblazer : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Trailblazer");
			Tooltip.SetDefault("Uses rockets as ammo\nDoes closer to 55 damage\n'Thou canst not kill that which doth not live.\nBut you can blast it into chunky kibbles.'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 15;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 68;
			Item.height = 24;
			Item.useTime = 38;
			Item.useAnimation = 38;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 1;
			Item.rare = 2;
			Item.autoReuse = true;
			Item.value = Item.buyPrice(gold: 5);
			Item.shootSpeed = 10f;
			Item.useAmmo = AmmoID.Rocket;
			Item.shoot = ProjectileID.GrenadeI;
			if (!Main.dedServ) {
				Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/OGGL");
            }
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-3, 0);
        }
	}
}