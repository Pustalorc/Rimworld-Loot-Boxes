﻿using Lanilor.LootBoxes.Mod;
using System.Collections.Generic;

namespace Lanilor.LootBoxes.Things
{
    public class CompUseEffectLootBoxSilverSmall : CompUseEffectLootBox
    {
        protected override LootBoxType LootBoxType => LootBoxType.SilverS;
        protected override int SetMinimum => ModLootBoxes.Settings?.SetMinSilverS ?? 2;
        protected override int SetMaximum => ModLootBoxes.Settings?.SetMaxSilverS ?? 3;
        protected override float MaximumMarketRewardValue => ModLootBoxes.Settings?.SilverSRewardValue ?? 300;

        protected override IEnumerable<LootboxReward> RewardTable => new List<LootboxReward>
        {
            new LootboxReward(8, new Reward("MealSurvivalPack", 1, 2, 5)),
            new LootboxReward(11, new Reward("MealNutrientPaste", 2, 3, 10)),
            new LootboxReward(11, new Reward("MealSimple", 2, 3, 10)),
            new LootboxReward(9, new Reward("MealFine", 1, 2, 10)),
            new LootboxReward(7, new Reward("MealLavish", 1, 2, 5)),
            new LootboxReward(11, new Reward("Kibble", 5, 10, 40)),
            new LootboxReward(7, new Reward("Chocolate", 2, 5, 15)),
            new LootboxReward(5, new Reward("InsectJelly", 5, 10, 40)),
            new LootboxReward(4, new Reward("MealSimple", 1, 2, 5), new Reward("MealFine", 1, 2, 5),
                new Reward("MealLavish", 1, 1, 4)),
            new LootboxReward(9, new Reward("Beer", 2, 5, 10)),
            new LootboxReward(9, new Reward("SmokeleafJoint", 2, 5, 10)),
            new LootboxReward(1, new Reward("GoJuice", 1, 2, 5)),
            new LootboxReward(3, new Reward("Penoxycyline", 1, 2, 5)),
            new LootboxReward(4, new Reward("Yayo", 1, 2, 5)),
            new LootboxReward(3, new Reward("WakeUp", 1, 2, 5)),
            new LootboxReward(1, new Reward("SmokeleafJoint", 1, 2, 5), new Reward("Yayo", 1, 2, 4),
                new Reward("WakeUp", 1, 2, 4)),
            new LootboxReward(1, new Reward("SimpleProstheticLeg")),
            new LootboxReward(1, new Reward("SimpleProstheticArm")),
            new LootboxReward(1, new Reward("SimpleProstheticHeart")),
            new LootboxReward(1, new Reward("CochlearImplant")),
            new LootboxReward(6, new Reward("MedicineIndustrial", 1, 2, 4)),
            new LootboxReward(7, new Reward("ComponentIndustrial", 1, 2, 4)),
            new LootboxReward(2, new Reward("Neutroamine", 2, 5, 15)),
            new LootboxReward(6, new Reward("Chemfuel", 5, 10, 50)),
            new LootboxReward(5, new Reward("Shell_HighExplosive", 1, 1, 4)),
            new LootboxReward(5, new Reward("Shell_Incendiary", 1, 1, 4)),
            new LootboxReward(4, new Reward("Shell_EMP", 1, 1, 2)),
            new LootboxReward(4, new Reward("Shell_Firefoam", 1, 1, 2)),
            new LootboxReward(3, new Reward("ElephantTusk", 1, 1, 2)),
            new LootboxReward(1, new Reward("MeleeWeapon_Mace")),
            new LootboxReward(1, new Reward("MeleeWeapon_LongSword")),
            new LootboxReward(1, new Reward("MeleeWeapon_Spear")),
            new LootboxReward(2, new Reward("Gun_Revolver", 1, 1, 2)),
            new LootboxReward(2, new Reward("Gun_Autopistol", 1, 1, 2)),
            new LootboxReward(1, new Reward("Gun_MachinePistol")),
            new LootboxReward(1, new Reward("Gun_IncendiaryLauncher")),
            new LootboxReward(1, new Reward("Gun_BoltActionRifle")),
            new LootboxReward(1, new Reward("Gun_PumpShotgun")),
            new LootboxReward(1, new Reward("Apparel_SmokepopBelt")),
            new LootboxReward(3, new Reward("Apparel_CowboyHat", 1, 1, 3)),
            new LootboxReward(3, new Reward("Apparel_BowlerHat", 1, 1, 3)),
            new LootboxReward(3, new Reward("Apparel_Tuque", 1, 1, 3)),
            new LootboxReward(3, new Reward("Apparel_Parka")),
            new LootboxReward(3, new Reward("Apparel_Pants", 1, 1, 2)),
            new LootboxReward(3, new Reward("Apparel_BasicShirt", 1, 1, 2)),
            new LootboxReward(3, new Reward("Apparel_CollarShirt", 1, 1, 2)),
            new LootboxReward(3, new Reward("Apparel_Duster")),
            new LootboxReward(7, new Reward("Silver", 20, 30, 50)),
            new LootboxReward(4, new Reward("Gold", 1, 2, 10)),
            new LootboxReward(11, new Reward("Steel", 10, 20, 50)),
            new LootboxReward(5, new Reward("Plasteel", 1, 2, 10)),
            new LootboxReward(11, new Reward("WoodLog", 10, 20, 75)),
            new LootboxReward(6, new Reward("Jade", 2, 5, 10)),
            new LootboxReward(7, new Reward("Steel", 10, 20, 40), new Reward("WoodLog", 10, 20, 40)),
            new LootboxReward(8, new Reward("Cloth", 10, 20, 50)),
            new LootboxReward(4, new Reward("Synthread", 5, 10, 75)),
            new LootboxReward(1, new Reward("DevilstrandCloth", 10, 20, 50)),
            new LootboxReward(3, new Reward("Leather_Panthera", 10, 20, 50)),
            new LootboxReward(3, new Reward("Leather_Camel", 10, 20, 50)),
            new LootboxReward(3, new Reward("Leather_Bluefur", 10, 20, 50)),
            new LootboxReward(3, new Reward("Leather_Bear", 10, 20, 50)),
            new LootboxReward(2, new Reward("Leather_Elephant", 10, 20, 50)),
            new LootboxReward(2, new Reward("LootBoxTreasure")),
            new LootboxReward(2, new Reward("LootBoxSilverSmall")),
            new LootboxReward(1, new Reward("LootBoxSilverLarge")),
            new LootboxReward(1, new Reward("LootBoxPandora"))
        };
    }
}