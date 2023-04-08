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
	public class BioshockLauncher : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Grenade Launcher");
			Tooltip.SetDefault("Uses rockets as ammo\nDoes closer to 45 damage\n33% chance to not consume ammo");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 5;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 64;
			Item.height = 26;
			Item.useTime = 60;
			Item.useAnimation = 60;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 5;
			Item.rare = 2;
			Item.autoReuse = false;
			Item.value = Item.buyPrice(gold: 5);
			Item.shootSpeed = 16f;
			Item.useAmmo = AmmoID.Rocket;
			Item.shoot = ProjectileID.GrenadeI;
			if (!Main.dedServ) {
				Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/BioshockNade");
            }
		}

		public override bool CanConsumeAmmo(Item ammo, Player player)
		{
			return Main.rand.NextFloat() >= 0.33f;
		}

		public override Vector2? HoldoutOffset()
        {
            return new Vector2(0, 0);
        }
	}
}