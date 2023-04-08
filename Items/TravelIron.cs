using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace CaffinatedMod.Items
{
    public class TravelIron : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Travel Size Elixir of Iron");
            Tooltip.SetDefault("Increases max life by 50");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 30;
        }

        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 30;
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useAnimation = 17;
            Item.useTime = 17;
            Item.useTurn = true;
            Item.UseSound = SoundID.Item3;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.rare = 1;
            Item.potion = false;
            Item.buffType = ModContent.BuffType<Buffs.IronElixorBuff>();
            Item.buffTime = 7200;
            Item.value = Item.buyPrice(silver: 5);
        }
    }
}