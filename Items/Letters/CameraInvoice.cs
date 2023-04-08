using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Letters
{
	public class CameraInvoice : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Peculiar Invoice");
			Tooltip.SetDefault("Orders an offensive accessory\nfrom an alternate dimension,\ndeposit this into the Mysterious Mailbox");
		}

		public override void SetDefaults() {
			Item.width = 22;
			Item.height = 12;
            Item.maxStack = 30;
            Item.rare = ItemRarityID.Blue;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.value = Item.buyPrice(gold: 1);
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.Amber, 1)
				.AddIngredient(ItemID.BlackLens, 1)
				.AddIngredient(ItemID.Lens, 8)
				.AddIngredient(Mod, "StampedLetter")
				.Register();
		}
	}
}