using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CaffinatedMod.Items.Accessories
{
	[AutoloadEquip(EquipType.Head)]
	public class PyramidThing : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Pyramid Thing");
			Tooltip.SetDefault("+15% melee damage\n'The manifestation of James's guilt'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 26;
			Item.rare = 4;
			Item.value = Item.sellPrice(gold: 1);
			//Item.vanity = true;
			Item.defense = 15;
			Item.maxStack = 1;
		}
		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Melee) += 0.15f;
		}
	}
}