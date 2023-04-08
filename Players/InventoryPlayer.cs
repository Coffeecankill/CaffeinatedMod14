using CaffinatedMod.Items.Accessories.Tokens;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CaffinatedMod.Players
{
	public class InventoryPlayer : ModPlayer
	{
		public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath)
		{
			if (mediumCoreDeath)
			{
				return new[] {
					new Item(ModContent.ItemType<BlankToken>(), 1)
				};
			}

			return new[] {
				new Item(ModContent.ItemType<BlankToken>(), 1),
			};
		}
	}
}