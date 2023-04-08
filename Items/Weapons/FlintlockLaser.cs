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
	public class FlintlockLaser : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Homemade Laser Carbine");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.CloneDefaults(ItemID.SpaceGun);
			Item.damage = 15;
			Item.mana = 4;
			Item.knockBack = 2;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.UseSound = SoundID.Item158;
			Item.shoot = ProjectileID.PurpleLaser;
			/*
			if (!Main.dedServ) {
				Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/WazerWifle");
			} */
		}

		public override Vector2? HoldoutOffset()
        {
            return new Vector2(-1, 0);
        }

		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
		{
			type = ProjectileID.PurpleLaser;
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.FlintlockPistol, 1);
            recipe.AddIngredient(ItemID.Sapphire, 6);
			recipe.AddIngredient(ItemID.Bottle, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}