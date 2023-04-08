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
	public class NailPistol : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nailer");
			Tooltip.SetDefault("Fires bouncy nails\nBenefits from melee modifiers\n'A popular model for all the\nwrong reasons'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Revolver);
			Item.damage = 10;
			Item.crit = 0;
			Item.DamageType = DamageClass.Melee;
			Item.knockBack = 0;
			Item.value = Item.buyPrice(gold: 6);
			Item.rare = 1;
			Item.shootSpeed = 16f;
			if (!Main.dedServ)
				Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/Vlad");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 3);
		}

		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
		{
			if (type == ProjectileID.Bullet)
			{
				type = ProjectileType<Nail2>();
			}
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldCoin, 6);
			recipe.AddTile(null, "VendingMachineTileV2");
			recipe.Register();
		} 
	}
}