using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace CaffinatedMod.Items
{
    public class ManaSoda : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mana Soda");
            Tooltip.SetDefault("'When you're slowing this'll keep you going!'");
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
            Item.healMana = 80;
			Item.value = Item.buyPrice(silver: 3);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SilverCoin, 3);
            recipe.AddTile(null, "VendingMachineTile");
            recipe.Register();
				
			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverCoin, 2);
            recipe.AddTile(null, "VendingMachineTileV2");
            recipe.Register();

        }
    }
}