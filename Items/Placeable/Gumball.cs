using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Placeable
{
    public class Gumball : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gumball Machine");
            Tooltip.SetDefault("<right> with silver coins to purchase Gumballs!\n'Trick or treat!'");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.useStyle = 1;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.maxStack = 99;
            Item.rare = ItemRarityID.Blue;
            Item.consumable = true;
            Item.createTile = TileType<Tiles.GumballTile>();
            Item.width = 30;
            Item.height = 38;
            Item.value = 1000;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
            .AddRecipeGroup("IronBar", 4)
            .AddIngredient(ItemID.Glass, 2)
            .AddIngredient(ItemID.GoodieBag, 1)
            .AddTile(TileID.Anvils)
            .Register();

        }
    }
}