using System.Collections.Generic;
using System.Drawing;
using TrialOfFortune.Cards;

namespace TrialOfFortune.Decks
{
    public class DeckOfHeroCards : Deck<HeroCard>
    {
        private const int NUMBER_OF_HERO_CARDS = 6;
        private string[] names;
        private Image[] artImages;
        private Image[] miniArtImages;
        private int[] healthPoints;
        private int[] actionPoints;
        private EntityStats[] stats;

        #region Constructors
        public DeckOfHeroCards()
        {
            names = new string[NUMBER_OF_HERO_CARDS]
            {
                "Ranger",
                "Druid",
                "Miner",
                "Necromancer",
                "Berserker",
                "Juggernaut"
            };

            artImages = new Image[NUMBER_OF_HERO_CARDS]
            {
                AssetsHeroes.RANGER,
                AssetsHeroes.DRUID,
                AssetsHeroes.MINER,
                AssetsHeroes.NECROMANCER,
                AssetsHeroes.BERSERKER,
                AssetsHeroes.JUGGERNAUT
            };

            miniArtImages = new Image[NUMBER_OF_HERO_CARDS]
            {
                AssetsHeroes.miniRANGER,
                AssetsHeroes.miniDRUID,
                AssetsHeroes.miniMINER,
                AssetsHeroes.miniNECROMANCER,
                AssetsHeroes.miniBERSERKER,
                AssetsHeroes.miniJUGGERNAUT
            };

            healthPoints = new int[NUMBER_OF_HERO_CARDS] { 1, 1, 2, 1, 1, 1 };
            actionPoints = new int[NUMBER_OF_HERO_CARDS] { 2, 2, 2, 3, 1, 2 };
            stats = new EntityStats[NUMBER_OF_HERO_CARDS]
            {
                new EntityStats(2, 14, AbilityEnum.EvasiveFire),
                new EntityStats(1, 16, AbilityEnum.NatureCall),
                new EntityStats(1, 13, AbilityEnum.GoldRush),
                new EntityStats(2, 14, AbilityEnum.SummonSkeleton),
                new EntityStats(3, 14, AbilityEnum.BushSkull),
                new EntityStats(0, 17, AbilityEnum.Charge)
            };

            //Abilities not added to entity stats
            var heroCards = new List<HeroCard>();
            CardFactory cardFactory = new CardFactory();
            for (int i = 0; i < NUMBER_OF_HERO_CARDS; i++)
            {
                heroCards.Add(cardFactory.CreateHeroCard(names[i], artImages[i], miniArtImages[i], healthPoints[i], actionPoints[i], stats[i]));
            }

            listOfCards.AddRange(heroCards);
        }
        #endregion
    }
}
