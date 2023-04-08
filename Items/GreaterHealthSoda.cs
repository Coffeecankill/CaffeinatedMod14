using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace CaffinatedMod.Items
{
    public class GreaterHealthSoda : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Greater Health Soda");
            Tooltip.SetDefault("'Wonderfully sweet for a taste that can't be beat!'");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
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
            Item.rare = 3;
            Item.healLife = 160;
            Item.potion = true;
			Item.value = Item.buyPrice(silver: 50);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SilverCoin, 35);
            recipe.AddTile(null, "VendingMachineTileV3");
            recipe.Register();

            recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SilverCoin, 30);
            recipe.AddTile(null, "VendingMachineTileV4");
            recipe.Register();
        }
    }
}