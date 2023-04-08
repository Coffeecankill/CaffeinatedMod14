using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Placeable
{
    public class StonePallet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pallet of Stone");
            Tooltip.SetDefault("<right> to open\nContains a large quantity of stone");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 48;
            Item.height = 52;
            Item.maxStack = 99;
            Item.rare = ItemRarityID.White;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.createTile = TileType<Tiles.StonePalletTile>();
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void ModifyItemLoot(ItemLoot itemLoot) {
            base.ModifyItemLoot(itemLoot);

            itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.StoneBlock, 1, 999, 999));
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddRecipeGroup("Wood", 15)
                .AddIngredient(ItemID.Rope, 25)
                .AddIngredient(ItemID.StoneBlock, 999)
                .AddTile(TileID.WorkBenches)
                .Register();

        }
    }
}