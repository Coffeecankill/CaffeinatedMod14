using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class NordGreatsword : ModItem
	{
		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Ancient Nord Greatsword");
			Tooltip.SetDefault("'Sovngarde saraan!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 25;
			//Item.crit = 20;
			Item.DamageType = DamageClass.Melee;
			Item.width = 60;
			Item.height = 60;
			Item.useTime = 40;
			Item.useAnimation = 40;
			Item.autoReuse = true;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(gold: 2);
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.useStyle = 1;
		}
	}
}