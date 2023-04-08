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
	public class DinoLaser : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Gecko Laser Rifle");
			Tooltip.SetDefault("'Advanced tech forged by an ancient race'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.CloneDefaults(ItemID.SpaceGun);
			Item.damage = 10;
			Item.mana = 3;
			Item.knockBack = 2;
			Item.useTime = 9;
			Item.useAnimation = 9;
			Item.shoot = ProjectileType<YellowLaser>();
			Item.UseSound = SoundID.Item158;
		}

		public override Vector2? HoldoutOffset()
        {
            return new Vector2(2, 3);
        }

		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
		{
			type = ProjectileType<YellowLaser>();
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.FossilOre, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}