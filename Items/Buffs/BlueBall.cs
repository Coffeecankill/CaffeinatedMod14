using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace CaffinatedMod.Items.Buffs
{
    public class BlueBall : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bluequa Gumball");
            Tooltip.SetDefault("Breathe underwater\n'A Blueberry delight!'");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 30;
        }

        public override void SetDefaults()
        {
            Item.width = 14;
            Item.height = 14;
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useTurn = true;
            Item.UseSound = SoundID.Item2;
            Item.maxStack = 99;
            Item.consumable = true;
            Item.rare = 1;
            Item.value = Item.buyPrice(silver: 1);
            Item.buffType = ModContent.BuffType<Buffs.BlueballBuff>();
            Item.buffTime = 14400;
        }
    }
}