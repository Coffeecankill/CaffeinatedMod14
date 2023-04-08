using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class GreatKnife : ModItem
	{
		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Great Knife");
			Tooltip.SetDefault("'My rofl knife goes\nslice! slice! slice!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 70;
			Item.crit = 20;
			Item.DamageType = DamageClass.Melee;
			Item.width = 70;
			Item.height = 76;
			Item.useTime = 32;
			Item.useAnimation = 32;
			Item.autoReuse = true;
			Item.knockBack = 8;
			Item.value = Item.buyPrice(gold: 15);
			Item.rare = 4;
			Item.UseSound = SoundID.Item1;
			Item.useStyle = 1;
		}
	}
}