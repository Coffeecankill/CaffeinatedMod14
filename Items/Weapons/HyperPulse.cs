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
	public class HyperPulse : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bakerbot Pulse Cannon");
			Tooltip.SetDefault("'Seems to be made of 2D printed plastic'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 86;
			Item.height = 24;
			Item.damage = 80;
			Item.DamageType = DamageClass.Magic;
			Item.shoot = ProjectileID.ShadowBeamFriendly;
			Item.channel = true;
			Item.mana = 40;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.useTime = 55;
			Item.useAnimation = 55;
			Item.knockBack = 7;
			Item.autoReuse = false;
			Item.rare = 2;
			Item.value = Item.buyPrice(gold: 5);
			Item.shootSpeed = 10f;
			if (!Main.dedServ)
			{
				Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/HyperCannon")
				{
					PitchVariance = .2f
				};
			}
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-12, 0);
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<DreamBar>(5)
				.AddIngredient(ItemID.MeteoriteBar, 15)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}