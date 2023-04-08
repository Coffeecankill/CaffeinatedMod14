using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using CaffinatedMod.Projectiles;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class SettlerAR : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Feltrite Assault Rifle");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 12;
			Item.DamageType = DamageClass.Magic;
			Item.width = 56;
			Item.channel = true;
			Item.mana = 5;
			Item.height = 30;
			Item.useTime = 8;
			Item.useAnimation = 8;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 1;
			Item.rare = 2;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 35);
			Item.shootSpeed = 12f;
			Item.shoot = ProjectileType<PulseBullet>();
			if (!Main.dedServ)
                Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/Pulse1");
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-14, 4);
        }

		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
		{
			velocity = velocity.RotatedByRandom(MathHelper.ToRadians(1));
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldCoin, 28);
			recipe.AddTile(null, "VendingMachineTileV2");
			recipe.Register();
		}
	}
}