using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class Shovel2 : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("The Painsaw");
			Tooltip.SetDefault("Increased armor penetration by 8\n'Doc, I keep seeing mutilated corpses!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.CloneDefaults(ItemID.CandyCaneSword);
			Item.UseSound = SoundID.Item22;
			Item.damage = 20;
			Item.width = 46;
			Item.height = 48;
			Item.axe = 20;
			Item.useTime = 15;
			Item.knockBack = 6;
			Item.autoReuse = true;
			Item.value = Item.buyPrice(gold: 8);
		}

		public override void HoldItem(Player player)
		{
			player.GetArmorPenetration(DamageClass.Generic) += 8;
		}

		public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldCoin, 8);
            recipe.AddTile(null, "VendingMachineTileV2");
            recipe.Register();
		}
	}
}