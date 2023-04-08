using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace CaffinatedMod.Items.Buffs
{
    public class ArmorBall : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Armornana Gumball");
            Tooltip.SetDefault("Increase defense by 4\n'Hard as a rock.'");
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
            Item.rare = 8;
            Item.value = Item.buyPrice(silver: 1);
            Item.buffType = ModContent.BuffType<Buffs.ArmorballBuff>();
            Item.buffTime = 14400;
        }
    }
}