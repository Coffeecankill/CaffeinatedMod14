using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class PostalPummler : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Postal Pummeler");
			Tooltip.SetDefault("Enemies killed will drop more money");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 21;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.knockBack = 4;
			Item.value = Item.buyPrice(gold: 1);
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.useStyle = 1;
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.Midas, 60);
		}

		public override void AddRecipes() 
		{
			CreateRecipe()
				.AddRecipeGroup("Wood", 7)
				.AddRecipeGroup("IronBar", 7)
				.AddRecipeGroup("GoldBars", 7)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}