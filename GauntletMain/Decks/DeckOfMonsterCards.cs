using System.Collections.Generic;
using TrialOfFortune.Classes;
using TrialOfFortune.Cards;
using System.Drawing;

namespace TrialOfFortune.Decks
{
    public class DeckOfMonsterCards : Deck<MonsterCard>
    {
        private const int NUMBER_OF_MONSTER_CARDS = 15;
        private string[] names;
        private Image[] artImages;
        private int[] damage;
        private EntityStats[] stats;
        private bool[] isAlive;
        private int[] coinsAwarded;

        #region Constructors
        public DeckOfMonsterCards()
        {
            names = new string[NUMBER_OF_MONSTER_CARDS]
            {
                "Hell Dog",
                "Lost Bandit",
                "Hallucination",
                "Molerat",
                "Fallen Adventurer",
                "Animated Statue",
                "Devourer",
                "Moss Giant",
                "Sewer Rat",
                "Volatile Goo",
                "Mutated Bat",
                "Zombie",
                "Troll",
                "Dusty Mimic Chest",
                "Toxic Spider"
            };

            artImages = new Image[NUMBER_OF_MONSTER_CARDS]
            {
                AssetsMonsters.DOG,
                AssetsMonsters.BANDIT,
                AssetsMonsters.HALLUCINATION,
                AssetsMonsters.MOLERAT,
                AssetsMonsters.ADVENTURER,
                AssetsMonsters.STATUE,
                AssetsMonsters.DEVOURER,
                AssetsMonsters.MOSSGIANT,
                AssetsMonsters.RAT,
                AssetsMonsters.GOO,
                AssetsMonsters.BAT,
                AssetsMonsters.ZOMBIE,
                AssetsMonsters.TROLL,
                AssetsMonsters.MIMIC,
                AssetsMonsters.SPIDER
            };

            damage = new int[NUMBER_OF_MONSTER_CARDS] { 1, 1, 2, 2, 2, 1, 2, 3, 1, 1, 2, 1, 2, 2, 2 };

            stats = new EntityStats[NUMBER_OF_MONSTER_CARDS]
            {
                 new EntityStats(15, 15),
                 new EntityStats(13, 12),
                 new EntityStats(17, 11),
                 new EntityStats(16, 15),
                 new EntityStats(17, 20),
                 new EntityStats(15, 19),
                 new EntityStats(14, 17),
                 new EntityStats(19, 21),
                 new EntityStats(13, 9), 
                 new EntityStats(15, 16),
                 new EntityStats(14, 13),
                 new EntityStats(18, 11),
                 new EntityStats(21, 17),
                 new EntityStats(10, 10),
                 new EntityStats(17, 14)
            };

            isAlive = new bool[NUMBER_OF_MONSTER_CARDS] { true, true, true, true, true, true, true, true, true, true, true, true, true, true, true };

            coinsAwarded = new int[NUMBER_OF_MONSTER_CARDS] { 1, 1, 1, 2, 3, 2, 2, 3, 1, 2, 1, 2, 4, 3, 2 };

            var monsterCards = new List<MonsterCard>();
            CardFactory cardFactory = new CardFactory();
            for (int i = 0; i < NUMBER_OF_MONSTER_CARDS; i++)
            {
                monsterCards.Add(cardFactory.CreateMonsterCard(names[i], artImages[i], damage[i], stats[i], isAlive[i], coinsAwarded[i]));
            }

            listOfCards.AddRange(monsterCards);
        }
        #endregion
    }
}
