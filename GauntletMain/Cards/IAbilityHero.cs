using TrialOfFortune.Classes;

namespace TrialOfFortune.Cards
{
    interface IAbilityHero
    {
        void ChargeFade(Player player);

        void SummonSkeletonFade(Player player);

        void GoldRushFade(Player player, MonsterCard card);

        void NatureCallFade(Player player);
    }
}
