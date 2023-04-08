using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using CaffinatedMod.Projectiles;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class Railgun : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Railgun");
			Tooltip.SetDefault("'Impressive!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 400;
			Item.noMelee = true;
			Item.DamageType = DamageClass.Magic;
			Item.channel = true;
			Item.mana = 50;
			Item.width = 62;
			Item.height = 24;
			Item.useTime = 60;
			Item.useAnimation = 60;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.rare = 8;
			Item.autoReuse = false;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 35);
			Item.shootSpeed = 16f;
			Item.shoot = ProjectileType<RailgunSlug>();
			if (!Main.dedServ) {
                Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/Railgun");
            }
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-8, 0);
        }
		/*
		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback) {
		Vector2 muzzleOffset = Vector2.Normalize(velocity) * 25f;
		if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
		{
			position += muzzleOffset;
		}
		*/

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldCoin, 21);
			recipe.AddTile(null, "VendingMachineTileV4");
			recipe.Register();
		}
	}
}