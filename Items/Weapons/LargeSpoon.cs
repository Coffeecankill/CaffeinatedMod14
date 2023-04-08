using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class LargeSpoon : ModItem
	{
		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Comically Large Spoon");
			Tooltip.SetDefault("'THIS IS A MELES WEAPON PACK ITEM!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 140;
			//Item.crit = 20;
			Item.DamageType = DamageClass.Melee;
			Item.width = 70;
			Item.height = 70;
			Item.useTime = 55;
			Item.useAnimation = 55;
			Item.autoReuse = true;
			Item.knockBack = 25;
			Item.value = Item.buyPrice(gold: 15);
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.useStyle = 1;
		}
	}
}