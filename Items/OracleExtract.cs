using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace CaffinatedMod.Items
{
    public class OracleExtract : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Looted Oracle's Extract");
            Tooltip.SetDefault("Shows the location of enemies\nAllows you to see nearby danger sources");
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
            Item.buffType = ModContent.BuffType<Buffs.OracleBuff>();
            Item.buffTime = 7200;
            Item.value = Item.buyPrice(silver: 5);
        }
    }
}