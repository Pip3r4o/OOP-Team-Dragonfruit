using TrialOfFortune.Cards;
using TrialOfFortune.Classes;
using System;

namespace TrialOfFortune.Cards
{
    [Serializable]
    public class Ability : IAbilityJuggernaut, IAbilityBerserker, IAbilityNecromancer, IAbilityMiner, IAbilityDruid, IAbilityRanger, IAbilityHero
    {
        
        public void Charge(Player player) //Juggernaut-specific ability
        {
            player.TotalAttackPoints += 5;
            --player.TotalActionPoints;
            player.UsedAbility = true;
            StaticResources.CurrentFightPhase = StaticResources.FightPhase.Fight;
        }

        public void ChargeFade(Player player)
        {
            player.TotalAttackPoints -= 5;
        }

        public void BashSkull(Player player, MonsterCard card) //Berserker-specific ability
        {
            player.TotalCoins += card.CoinsAwarded;
            --player.TotalActionPoints;
            StaticResources.CurrentFightPhase = StaticResources.FightPhase.NA;
            card.Alive = false;
        }

        public void SummonSkeleton(Player player) //Necromancer-specific ability
        {
            player.TotalDefensePoints += 4;
            --player.TotalActionPoints;
            player.UsedAbility = true;
            StaticResources.CurrentFightPhase = StaticResources.FightPhase.Fight;
        }

        public void SummonSkeletonFade(Player player)
        {
            player.TotalDefensePoints -= 4;
        }

        public void GoldRush(Player player) //Miner-specific ability
        {
            --player.TotalActionPoints;
            player.UsedAbility = true;
            StaticResources.CurrentFightPhase = StaticResources.FightPhase.Fight;
        }

        public void GoldRushFade(Player player, MonsterCard card)
        {
            if (!card.Alive)
            {
                player.TotalCoins += card.CoinsAwarded;
            }            
        }

        public void NatureCall(Player player) //Druid-specific ability
        {
            player.TotalAttackPoints += 4;
            --player.TotalActionPoints;
            player.UsedAbility = true;
            StaticResources.CurrentFightPhase = StaticResources.FightPhase.Fight;
        }

        public void NatureCallFade(Player player)
        {
            player.TotalAttackPoints -= 4;
        }

        public void EvasiveFire(Player player) //Ranger-specific ability
        {
            --player.TotalActionPoints;
            StaticResources.CurrentFightPhase = StaticResources.FightPhase.NA;
        }
    }
}
