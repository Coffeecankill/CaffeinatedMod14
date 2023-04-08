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
	public class Lasgun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kantrael Lasgun");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 56;
			Item.height = 18;
			Item.damage = 300;
			Item.DamageType = DamageClass.Magic;
			Item.shoot = ProjectileType<RedLaser>();
			Item.channel = true;
			Item.mana = 5;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.knockBack = 2;
			Item.autoReuse = false;
			Item.rare = 10;
			Item.value = Item.buyPrice(gold: 50);
			Item.shootSpeed = 16f;
			if (!Main.dedServ)
			{
				Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/Lasgun")
				{
					PitchVariance = .4f
				};
			}
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-8, 2);
		}

		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
		{
			type = ProjectileType<RedLaser>();
		}
		/*
		public override void AddRecipes()
		{
			CreateRecipe()
			.AddIngredient(ItemID.FragmentNebula, 18)
			.AddTile(TileID.LunarCraftingStation)
			.Register();
		}
		*/
	}
}