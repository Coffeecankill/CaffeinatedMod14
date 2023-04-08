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
	public class EnforcerBlaster : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Reaper");
			Tooltip.SetDefault("Two round burst\nOnly the first shot consumes mana");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 200;
			Item.noMelee = true;
			Item.DamageType = DamageClass.Magic;
			Item.channel = true;
			Item.mana = 20;
			Item.width = 54;
			Item.height = 42;
			Item.useTime = 18;
			Item.useAnimation = 36;
			Item.reuseDelay = 25;
			Item.useStyle = 5;
			Item.knockBack = 5;
			Item.rare = 7;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 30);
			Item.shoot = ProjectileType<YellowLaser>();
			Item.shootSpeed = 10f;
			if (!Main.dedServ) {
                Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/Blaster");
            }
		}

		public override bool? UseItem(Player player)
		{
			// Because we're skipping sound playback on use animation start, we have to play it ourselves whenever the item is actually used.
			if (!Main.dedServ && Item.UseSound.HasValue)
			{
				SoundEngine.PlaySound(Item.UseSound.Value, player.Center);
			}
			return null;
		}

		public override Vector2? HoldoutOffset()
        {
            return new Vector2(0, 0);
        }
	}
}