using CaffinatedMod.Items.Tiles;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace CaffinatedMod.Items.Placeable
{
	public class BitinthePantsBox : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Music Box (No.2 Ambient)");
			Tooltip.SetDefault("From HYPERCHARGE: Unboxed\n'A chill track that oozes in ambience with a touch of melancholy'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;

			// The following code links the music box's item and tile with a music track:
			//   When music with the given ID is playing, equipped music boxes have a chance to change their id to the given item type.
			//   When an item with the given item type is equipped, it will play the music that has musicSlot as its ID.
			//   When a tile with the given type and Y-frame is nearby, if its X-frame is >= 36, it will play the music that has musicSlot as its ID.
			// When getting the music slot, you should not add the file extensions!
			MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Music/BitinthePants"), ModContent.ItemType<BitinthePantsBox>(), ModContent.TileType<BitinthePantsBoxTile>());
		}

		public override void SetDefaults()
		{
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTurn = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.accessory = true;
			Item.autoReuse = true;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<BitinthePantsBoxTile>();
			Item.width = 24;
			Item.height = 24;
			Item.rare = ItemRarityID.Orange;
			Item.value = 5000;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<DreamBar>(3)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}