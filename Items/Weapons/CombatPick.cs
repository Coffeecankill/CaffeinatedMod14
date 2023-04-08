using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class CombatPick : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Combat Pickaxe");
			Tooltip.SetDefault("Has a secondary blade that\ninflicts poison on enemies");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 20;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 12;
			Item.useAnimation = 21;
			Item.pick = 55;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = Item.buyPrice(gold: 5);
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.Poisoned, 180);
		}
		
		public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldCoin, 4);
            recipe.AddTile(null, "VendingMachineTileV2");
            recipe.Register();
		}
	}
}