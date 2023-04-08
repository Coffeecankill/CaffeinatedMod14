using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace CaffinatedMod.Items
{
    public class GreaterManaSoda : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Greater Mana Soda");
            Tooltip.SetDefault("'Enjoy the hops because the world never stops!'");
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
            Item.rare = 3;
            Item.healMana = 180;
			Item.value = Item.buyPrice(silver: 5);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SilverCoin, 3);
            recipe.AddTile(null, "VendingMachineTileV3");
            recipe.Register();

            recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SilverCoin, 2);
            recipe.AddTile(null, "VendingMachineTileV4");
            recipe.Register();
        }
    }
}