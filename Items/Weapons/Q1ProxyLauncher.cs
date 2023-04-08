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
	public class Q1ProxyLauncher : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Minelayer");
			Tooltip.SetDefault("Uses rockets as ammo\nDoes closer to 80 damage\nMines deal triple damage when armed");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.ProximityMineLauncher);
			Item.damage = 30;
			Item.rare = 4;
			Item.useTime = 38;
			Item.useAnimation = 38;
			Item.knockBack = 1;
			Item.autoReuse = true;
			Item.useAmmo = AmmoID.Rocket;
			if (!Main.dedServ)
			{
				Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/OGGL");
			}
		}

		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
		{
			if (type == ProjectileID.RocketI)
			{
				type = ProjectileID.ProximityMineI;
			}
			if (type == ProjectileID.RocketII)
			{
				type = ProjectileID.ProximityMineII;
			}
			if (type == ProjectileID.RocketIII)
			{
				type = ProjectileID.ProximityMineIII;
			}
			if (type == ProjectileID.RocketIV)
			{
				type = ProjectileID.ProximityMineIV;
			}
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-3, 0);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldCoin, 25);
			recipe.AddTile(null, "VendingMachineTileV3");
			recipe.Register();
		}
	}
}