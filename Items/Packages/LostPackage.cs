using System.Collections.Generic;
using Terraria;
using CaffinatedMod.Items.Weapons;
using CaffinatedMod.Items;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CaffinatedMod.Items.Packages
{
	public class LostPackage : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lost Package");
            Tooltip.SetDefault("<right> to open\n'What's inside?'");
        }

		public override void SetDefaults() {
			Item.width = 10;
			Item.height = 10;
			Item.maxStack = 99;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(gold: 2);
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot) {
			base.ModifyItemLoot(itemLoot);

			itemLoot.Add(new LostPackageDropRule((ItemID.RainbowBrick, 99), (ItemID.UmbrellaHat, 1), (ItemID.ManaFlower, 1), (ItemID.GoldCoin, 15), (ItemID.GoldCoin, 15), (ItemID.WizardHat, 1), (ItemID.ArchaeologistsHat, 1), (ItemID.GoldDust, 20),
				(ItemID.DogWhistle, 1), (ItemID.Toolbox, 1), (ItemID.MysteriousCape, 1), (ItemID.Kimono, 1), (ItemID.CompanionCube, 1), (ItemID.Sunglasses, 1), (ItemID.WizardsHat, 1), (ItemID.LuckyHorseshoe, 1), (ItemID.FairyBell, 1), (ItemID.PortalGun, 1),
				(ItemID.DynastyWood, 500), (ItemID.CoralstoneBlock, 99), (ItemID.VikingHelmet, 1), (ItemID.AnglerTackleBag, 1), (ItemID.PygmyNecklace, 1), (ItemID.PlatinumCoin, 1), (ItemID.GoldenCrate, 5), (ItemID.IronCrate, 5), (ItemID.WoodenCrate, 5), (ItemID.HandWarmer, 1),
				(ItemID.ReaverShark, 1), (ItemID.SawtoothShark, 1), (ItemID.Carrot, 1), (ItemID.Jetpack, 1), (ItemID.GreenCap, 1), (ItemID.FlyingCarpet, 1), (ItemID.DivingHelmet, 1), (ItemID.Diamond, 10), (ItemID.GolfCart, 1), (ItemID.DarkMageBookMountItem, 1),
				(ItemID.SteampunkMinecart, 1), (ItemID.PDA, 1), (ItemID.NecromanticScroll, 1), (ItemID.EndlessQuiver, 1), (ItemID.EndlessMusketPouch, 1), (ItemID.NightVisionHelmet, 1), (ItemID.LightningBoots, 1), (ItemID.ObsidianShield, 1), (ItemID.IllegalGunParts, 3),
				(ItemID.WhitePearl, 5), (ItemID.PinkGel, 65), (ItemID.ChristmasTree, 5), (ItemID.IceMachine, 1), (ItemID.SWATHelmet, 1), (ItemID.TeaKettle, 1), (ItemID.Safe, 1), (ItemID.Cauldron, 1), (ItemID.BlendOMatic, 1), (ItemID.SweetheartNecklace, 1), (ItemID.AmberMosquito, 1),
				(ItemID.MasterBait, 30), (ItemID.SuperAbsorbantSponge, 1), (ItemID.LavaLamp, 5), (ItemID.BubbleMachine, 5), (ItemID.MoneyTrough, 1), (ItemID.TaxCollectorsStickOfDoom, 1), (ItemID.AleThrowingGlove, 1), (ItemID.PotionOfReturn, 10), (ItemID.HunterCloak, 1),
				(ItemID.RedHat, 1), (ItemID.PeddlersHat, 1), (ItemID.PainterPaintballGun, 1), (ItemID.UglySweater, 1), (ItemID.MagicLantern, 1), (ItemID.RoyalGel, 1), (ItemID.ChickenNugget, 20), (ItemID.ChocolateChipCookie, 10), (ItemID.PiggyBank, 1), (ItemID.RocketBoots, 1),
				(ItemID.SittingDucksFishingRod, 1), (ItemID.MechanicsRod, 1), (ItemID.GoldenBugNet, 1), (ItemID.StaffofRegrowth, 1), (ItemID.DiscountCard, 1), (ItemID.Seedling, 1), (ItemID.PlanteraPetItem, 1), (ItemID.UnluckyYarn, 1), (ItemID.RedRyder, 1), (ItemID.Present, 15),
				(ItemID.DontStarveShaderItem, 1), (ItemID.MoonLordLegs, 1), (ItemID.QueenSlimeHook, 1), (ItemID.CritterShampoo, 1), (ItemID.ConfettiCannon, 1), (ItemID.ConfettiCannon, 1), (ItemID.Geode, 1), (ItemID.GoldGoldfishBowl, 1), (ItemID.HunterCloak, 1), (ItemID.Skull, 1),
				(ItemID.QueenBeePetItem, 1), (ItemID.TeleportationPotion, 20), (ItemID.SpelunkerPotion, 20), (ItemID.LifeCrystal, 5), (ItemID.PumpkingPetItem, 1), (ItemID.EverscreamPetItem, 1), (ItemID.HerbBag, 3), (ItemID.BottomlessBucket, 1)));
		}
    }

	public class LostPackageDropRule : IItemDropRule
	{
		public (int, int)[] ids;

		public List<IItemDropRuleChainAttempt> ChainedRules { get; } = new();

		public LostPackageDropRule(params (int, int)[] ids) {
			this.ids = ids;
		}

		public bool CanDrop(DropAttemptInfo info) => true;

		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info) {
			(int id, int stack) = ids[info.rng.Next(ids.Length)];
			CommonCode.DropItem(info, id, stack);
			return new ItemDropAttemptResult
			{
				State = ItemDropAttemptResultState.Success
			};
		}

		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo) {
			float rate = 1f / ids.Length * ratesInfo.parentDroprateChance;
			for (int i = 0; i < ids.Length; i++)
				drops.Add(new DropRateInfo(ids[i].Item1, ids[i].Item2, ids[i].Item2, rate, ratesInfo.conditions));
			Chains.ReportDroprates(ChainedRules, 1, drops, ratesInfo);
		}
	}
}