using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace CaffinatedMod.Items
{
    public class TotalBiscuit : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Total Biscuit of Rejuvenation");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 30;
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 24;
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useAnimation = 17;
            Item.useTime = 17;
            Item.useTurn = true;
            Item.UseSound = SoundID.Item2;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.rare = 1;
            Item.healLife = 40;
            Item.healMana = 40;
			Item.value = Item.buyPrice(silver: 5);
        }
    }
}