using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class CEPistol : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("M6D Pistol");
			Tooltip.SetDefault("'I don't keep it loaded son...'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 350;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 17;
			Item.useAnimation = 17;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 5;
			Item.rare = 10;
			Item.autoReuse = false;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 2);
			Item.shootSpeed = 16f;
			Item.useAmmo = AmmoID.Bullet;
			if (!Main.dedServ)
				Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/CEPistol");
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-9, 5);
        }
		/*
		public override void AddRecipes()
		{
			CreateRecipe()
			.AddIngredient(ItemID.FragmentVortex, 18)
			.AddTile(TileID.LunarCraftingStation)
			.Register();
		}
		*/
	}
}