using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items
{
	public class HallowedOre : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Hallowed Ore");
		}

		public override void SetDefaults() {
			Item.width = 16;
			Item.height = 16;
            Item.maxStack = 9999;
            Item.rare = 4;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.value = Item.buyPrice(gold: 1);
		}
	}
}