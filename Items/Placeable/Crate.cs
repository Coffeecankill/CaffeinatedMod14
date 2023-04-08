/*
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Placeable
{
	public class Crate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Iron Checkpoint Crate");
			Tooltip.SetDefault("<right> to set spawn\n'Once saved the planet by beating\nthe fastest racer in the galaxy,\nnow it's content to help save\nthe world once again!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.useStyle = 1;
			Item.useTurn = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.autoReuse = true;
			Item.maxStack = 30;
			Item.rare = ItemRarityID.Blue;
			Item.consumable = true;
			Item.createTile = TileType<Tiles.CrateTile>();
			Item.width = 34;
			Item.height = 34;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
			.AddRecipeGroup("IronBar", 15)
			.AddTile(TileID.Anvils)
			.Register();
		}
	}
}
*/