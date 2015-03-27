using System.Collections.Generic;

namespace GauntletMain.Classes
{
    class DeckOfHeroCards : Deck<HeroCard>
    {
        #region Constructors
        public DeckOfHeroCards()
        {
            //Abilities not added to entity stats
            HeroCard rangerCard = new HeroCard("Ranger", AssetsHeroes.RANGER, AssetsHeroes.miniRANGER, 1, 2, new EntityStats(2, 14));
            HeroCard druidCard = new HeroCard("Druid", AssetsHeroes.DRUID, AssetsHeroes.miniDRUID, 1, 2, new EntityStats(1, 16));
            HeroCard minerCard = new HeroCard("Miner", AssetsHeroes.MINER, AssetsHeroes.miniMINER, 2, 2, new EntityStats(1, 13));
            HeroCard necromancerCard = new HeroCard("Necromancer", AssetsHeroes.NECROMANCER, AssetsHeroes.miniNECROMANCER, 1, 3, new EntityStats(2, 14));
            HeroCard berserkerCard = new HeroCard("Berserker", AssetsHeroes.BERSERKER, AssetsHeroes.miniBERSERKER, 1, 1, new EntityStats(3, 14));
            HeroCard juggernautCard = new HeroCard("Juggernaut", AssetsHeroes.JUGGERNAUT, AssetsHeroes.miniJUGGERNAUT, 1, 2, new EntityStats(0, 17));

            listOfCards.AddRange(new List<HeroCard>
            {
                rangerCard,
                druidCard,
                minerCard,
                necromancerCard,
                berserkerCard,
                juggernautCard
            });
        }
        #endregion
    }
}
