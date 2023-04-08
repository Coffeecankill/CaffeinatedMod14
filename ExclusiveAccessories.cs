/*
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace CaffinatedMod
{
	public class ExclusiveAccessories : Mod
	{
		public abstract class CopperTokenAccessory : ModItem
		{
			public override void SetStaticDefaults()
			{
				CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
			}

			public override void SetDefaults()
			{
				Item.accessory = true;
			}

			public override bool CanAccessoryBeEquippedWith(Item equippedItem, Item incomingItem, Player player)
			{
				if (equippedItem.ModItem is CopperTokenAccessory && incomingItem.ModItem is CopperTokenAccessory)
					return false;
				return true;
			}
		}
	}
}
*/