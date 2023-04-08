using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Weapons
{
	public class CandlestickPlat : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Candlestick");
			Tooltip.SetDefault("Functions as a sword\nBenefits from magic modifiers");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 20;
			Item.noMelee = false;
			Item.DamageType = DamageClass.Magic;
			Item.width = 48;
			Item.height = 46;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 7;
			Item.value = Item.buyPrice(gold: 1);
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool(3))
			{
				if (player.altFunctionUse == 2)
				{
					int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 169, 0f, 0f, 150, default(Color), 2f);
					Main.dust[dust].noGravity = false;
					Main.dust[dust].velocity.X += player.direction * 2f;
					Main.dust[dust].velocity.Y += 0.2f;
				}
				else
				{
					int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Torch, player.velocity.X * 0.2f + (float)(player.direction * 8), player.velocity.Y * 0.2f, 100, default(Color), 2.5f);
					Main.dust[dust].noGravity = true;
				}
			}
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.OnFire, 300);
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.PlatinumCandle, 1)
				.AddIngredient(ItemID.Book, 1)
				.AddIngredient(ItemID.PlatinumBar, 6)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}