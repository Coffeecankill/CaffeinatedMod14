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
	public class Disruptor : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Disruptor");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 35;
			Item.DamageType = DamageClass.Magic;
			Item.width = 64;
			Item.channel = true;
			Item.mana = 7;
			Item.height = 28;
			Item.useTime = 6;
			Item.useAnimation = 6;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 1;
			Item.rare = 7;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 15);
			Item.shootSpeed = 14f;
			Item.shoot = ProjectileID.AmethystBolt;
			if (!Main.dedServ)
                Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/Disruptor");
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(4, -3);
        }
	}
}