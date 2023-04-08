using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class GiantToothbrush : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Giant Toothbrush");
			Tooltip.SetDefault("Enemies killed will drop more money\n'Time to break a little bad.'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.damage = 90;
			//Item.crit = 20;
			Item.DamageType = DamageClass.Melee;
			Item.width = 70;
			Item.height = 70;
			Item.useTime = 28;
			Item.useAnimation = 28;
			Item.autoReuse = true;
			Item.knockBack = 9;
			Item.value = Item.buyPrice(gold: 15);
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.useStyle = 1;
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Midas, 180);
		}
	}
}