using Microsoft.Xna.Framework;
using Terraria.GameContent.Creative;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using CaffinatedMod.Projectiles;
using Terraria.Audio;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class HomemadeRifleGoldMags : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Homemade Automatic Rifle");
			Tooltip.SetDefault("Upgraded with an ammo belt\n75% chance to not consume ammo\n'Sometimes, I forget to reload.'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 20;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 66;
			Item.height = 20;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 4;
			Item.rare = 3;
			//Item.UseSound = SoundID.Item41;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.value = Item.buyPrice(silver: 50);
			Item.shootSpeed = 12f;
			Item.useAmmo = AmmoID.Bullet;
			if (!Main.dedServ)
				Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/Machinegun");
		}

		public override bool CanConsumeAmmo(Item ammo, Player player)
		{
			return Main.rand.NextFloat() >= 0.75f;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-6, 0);
		}
				
        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback) {
			Vector2 muzzleOffset = Vector2.Normalize(velocity) * 25f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, -5, 0))
			{
				position += muzzleOffset;
			}
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.MusketBall, 999);
			recipe.AddIngredient(ItemID.IvyChest, 1);
			recipe.AddIngredient(ItemID.ManaCrystal, 1);
			recipe.AddIngredient(Mod.Find<ModItem>("HomemadeRifleGold").Type);
            recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}