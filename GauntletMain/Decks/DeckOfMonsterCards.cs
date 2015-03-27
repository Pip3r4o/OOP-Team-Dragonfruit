using System.Collections.Generic;
using GauntletMain.Classes;

namespace GauntletMain.Decks
{
    class DeckOfMonsterCards : Deck<MonsterCard>
    {
        #region Constructors
        public DeckOfMonsterCards()
        {
            MonsterCard monster1 = new MonsterCard("Hell Dog", AssetsMonsters.DOG, 1, new EntityStats(15, 15), true, 1);
            MonsterCard monster2 = new MonsterCard("Lost Bandit", AssetsMonsters.BANDIT, 1, new EntityStats(13, 12), true, 1);
            MonsterCard monster3 = new MonsterCard("Hallucination", AssetsMonsters.HALLUCINATION, 2, new EntityStats(17, 11), true, 1);
            MonsterCard monster4 = new MonsterCard("Molerat", AssetsMonsters.MOLERAT, 2, new EntityStats(16, 15), true, 2);
            MonsterCard monster5 = new MonsterCard("Fallen Adventurer", AssetsMonsters.ADVENTURER, 2, new EntityStats(17, 20), true, 3);
            MonsterCard monster6 = new MonsterCard("Animated Statue", AssetsMonsters.STATUE, 1, new EntityStats(15, 19), true, 2);
            MonsterCard monster7 = new MonsterCard("Devourer", AssetsMonsters.DEVOURER, 2, new EntityStats(14, 17), true, 2);
            MonsterCard monster8 = new MonsterCard("Moss Giant", AssetsMonsters.MOSSGIANT, 3, new EntityStats(19, 21), true, 3);
            MonsterCard monster9 = new MonsterCard("Sewer Rat", AssetsMonsters.RAT, 1, new EntityStats(13, 9), true, 1);
            MonsterCard monster10 = new MonsterCard("Volatile Goo", AssetsMonsters.GOO, 1, new EntityStats(15, 16), true, 2);
            MonsterCard monster11 = new MonsterCard("Mutated Bat", AssetsMonsters.BAT, 2, new EntityStats(14, 13), true, 1);
            MonsterCard monster12 = new MonsterCard("Zombie", AssetsMonsters.ZOMBIE, 1, new EntityStats(18, 11), true, 2);
            MonsterCard monster13 = new MonsterCard("Troll", AssetsMonsters.TROLL, 2, new EntityStats(21, 17), true, 4);
            MonsterCard monster14 = new MonsterCard("Dusty Mimic Chest", AssetsMonsters.MIMIC, 2, new EntityStats(10, 10), true, 3);
            MonsterCard monster15 = new MonsterCard("Toxic Spider", AssetsMonsters.SPIDER, 2, new EntityStats(17, 14), true, 2);

            listOfCards.AddRange(new List<MonsterCard>
            {
                        monster1,
                        monster2,
                        monster3,
                        monster4,
                        monster5,
                        monster6,
                        monster7,
                        monster8,
                        monster9,
                        monster10,
                        monster11,
                        monster12,
                        monster13,
                        monster14,
                        monster15
            });
        }
        #endregion
    }
}
