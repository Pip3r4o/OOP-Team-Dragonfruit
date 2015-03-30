using TrialOfFortune.Classes;
using System;

namespace TrialOfFortune
{
    [Serializable]
    public class Ability
    {
        
        public static void Charge(Player player) //Juggernaut-specific ability
        {
            player.TotalAttackPoints += 5;
            --player.TotalActionPoints;
            player.UsedAbility = true;
            StaticResources.CurrentFightPhase = StaticResources.FightPhase.Fight;
        }

        public static void ChargeFade(Player player)
        {
            player.TotalAttackPoints -= 5;
        }

        public static void BashSkull(Player player, MonsterCard card) //Berserker-specific ability
        {
            player.TotalCoins += card.CoinsAwarded;
            --player.TotalActionPoints;
            StaticResources.CurrentFightPhase = StaticResources.FightPhase.NA;
            card.Alive = false;
        }

        public static void SummonSkeleton(Player player) //Necromancer-specific ability
        {
            player.TotalDefensePoints += 4;
            --player.TotalActionPoints;
            player.UsedAbility = true;
            StaticResources.CurrentFightPhase = StaticResources.FightPhase.Fight;
        }

        public static void SummonSkeletonFade(Player player)
        {
            player.TotalDefensePoints -= 4;
        }

        public static void GoldRush(Player player) //Miner-specific ability
        {
            --player.TotalActionPoints;
            player.UsedAbility = true;
            StaticResources.CurrentFightPhase = StaticResources.FightPhase.Fight;
        }

        public static void GoldRushFade(Player player, MonsterCard card)
        {
            if (!card.Alive)
            {
                player.TotalCoins += card.CoinsAwarded;
            }            
        }
        public static void NatureCall(Player player) //Druid-specific ability
        {
            player.TotalAttackPoints += 4;
            --player.TotalActionPoints;
            player.UsedAbility = true;
            StaticResources.CurrentFightPhase = StaticResources.FightPhase.Fight;
        }

        public static void NatureCallFade(Player player)
        {
            player.TotalAttackPoints -= 4;
        }
        public static void EvasiveFire(Player player) //Ranger-specific ability
        {
            --player.TotalActionPoints;
            StaticResources.CurrentFightPhase = StaticResources.FightPhase.NA;
        }
    }
}
