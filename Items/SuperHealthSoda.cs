using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace CaffinatedMod.Items
{
    public class SuperHealthSoda : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Super Health Soda");
            Tooltip.SetDefault("'This brew is a breakthrough!'");
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
            Item.rare = 7;
            Item.healLife = 220;
            Item.potion = true;
			Item.value = Item.buyPrice(silver: 50);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SilverCoin, 25);
            recipe.AddTile(null, "VendingMachineTileV5");
            recipe.Register();
        }
    }
}