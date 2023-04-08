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
	public class DoomPlasma : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("D-93 Plasma Rifle");
			Tooltip.SetDefault("'Built by the UAC and powered by Argent energy'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 26;
			Item.DamageType = DamageClass.Magic;
			Item.width = 64;
			Item.channel = true;
			Item.mana = 5;
			Item.height = 28;
			Item.useTime = 5;
			Item.useAnimation = 5;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 4;
			Item.rare = 7;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 15);
			Item.shootSpeed = 10f;
			Item.shoot = ProjectileID.SapphireBolt;
			if (!Main.dedServ)
                Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/DoomPlasma");
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(4, -3);
        }
	}
}