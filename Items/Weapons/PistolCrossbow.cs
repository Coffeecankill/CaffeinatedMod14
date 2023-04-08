using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class PistolCrossbow : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Pistol Crossbow");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 25;
			Item.DamageType = DamageClass.Ranged;
			//Item.crit = 21;
			Item.width = 40;
			Item.height = 22;
			Item.useTime = 38;
			Item.useAnimation = 38;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 5;
			Item.rare = 1;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = false;
			Item.shoot = 10;
			Item.value = Item.buyPrice(silver: 20);
			Item.shootSpeed = 6f;
			Item.useAmmo = AmmoID.Arrow;
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(3, 0);
        }

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddRecipeGroup("Wood", 4);
			recipe.AddRecipeGroup("IronBar", 6);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}