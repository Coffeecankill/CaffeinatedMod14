using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace CaffinatedMod.Items
{
    public class HealthSoda : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Health Soda");
            Tooltip.SetDefault("'Delicious and bold; enjoy ice cold!'");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 30;
        }

        public override void SetDefaults()
        {
            Item.width = 6;
            Item.height = 12;
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useAnimation = 17;
            Item.useTime = 17;
            Item.useTurn = true;
            Item.UseSound = SoundID.Item3;
            Item.maxStack = 99;
            Item.consumable = true;
            Item.rare = 1;
            Item.healLife = 80;
            Item.potion = true;
			Item.value = Item.buyPrice(silver: 10);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SilverCoin, 10);
            recipe.AddTile(null, "VendingMachineTile");
            recipe.Register();
			
			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverCoin, 8);
            recipe.AddTile(null, "VendingMachineTileV2");
            recipe.Register();

        }
    }
}