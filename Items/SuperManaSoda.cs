using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace CaffinatedMod.Items
{
    public class SuperManaSoda : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Super Mana Soda");
            Tooltip.SetDefault("'Our best with the perfect amount of zest!'");
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
            Item.rare = 4;
            Item.healMana = 280;
			Item.value = Item.buyPrice(silver: 5);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SilverCoin, 2);
            recipe.AddTile(null, "VendingMachineTileV5");
            recipe.Register();
        }
    }
}