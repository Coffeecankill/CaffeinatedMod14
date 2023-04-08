using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class FlareRevolver : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Spitfire Revolver");
			Tooltip.SetDefault("'It's toasty time!'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 20;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 56;
			Item.height = 20;
			Item.useTime = 9;
			Item.useAnimation = 9;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 5;
			Item.rare = 2;
			Item.autoReuse = false;
			Item.shoot = 10;
			Item.value = Item.buyPrice(gold: 10);
			Item.shootSpeed = 12f;
			Item.useAmmo = AmmoID.Bullet;
			Item.shoot = ProjectileID.ImpFireball;
			if (!Main.dedServ) {
				Item.UseSound = new SoundStyle("CaffinatedMod/Sounds/Custom/FlareRevolver");
			}
		}

		public override Vector2? HoldoutOffset()
        {
            return new Vector2(-3, 0);
        }

		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
		{
			type = ProjectileID.ImpFireball;

			Vector2 muzzleOffset = Vector2.Normalize(velocity) * 12f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Revolver, 1);
            recipe.AddIngredient(ItemID.Wire, 2);
			recipe.AddIngredient(ItemID.Gel, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}