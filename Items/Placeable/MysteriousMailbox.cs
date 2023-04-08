using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Placeable
{
    public class MysteriousMailbox : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mysterious Mailbox");
            Tooltip.SetDefault("<right> to claim invoices\n'This mailbox radiates with magic.'");
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
            Item.createTile = TileType<Tiles.MysteriousMailboxTile>();
            Item.width = 30;
            Item.height = 38;
            Item.value = 3000;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
            .AddRecipeGroup("IronBar", 8)
            .AddIngredient(ItemID.ManaCrystal, 1)
            .AddTile(TileID.Anvils)
            .Register();

        }
    }
}