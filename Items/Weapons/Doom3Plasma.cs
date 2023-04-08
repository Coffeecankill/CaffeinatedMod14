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
	public class Doom3Plasma : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Series 3 Plasma Rifle");
			Tooltip.SetDefault("'Early model built by the UAC'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 45;
			Item.DamageType = DamageClass.Magic;
			Item.width = 80;
			Item.channel = true;
			Item.mana = 6;
			Item.height = 42;
			Item.useTime = 8;
			Item.useAnimation = 8;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 6;
			Item.rare = 7;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 15);
			Item.shootSpeed = 10f;
			Item.shoot = ProjectileID.SapphireBolt;
			if (!Main.dedServ)
                Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/Doom3Plasma");
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-19, 0);
        }
	}
}