using TrialOfFortune.Classes;
using TrialOfFortune.Cards;

namespace TrialOfFortune.Decks
{
    public class DeckOfEncounterCards : Deck<EncounterCard>
    {
        #region Constructors
        public DeckOfEncounterCards()
        {
            DeckFactory deckFactory = new DeckFactory();
            DeckOfMonsterCards deckOfMonsterCards = deckFactory.CreateDeckOfMonsterCards();
            DeckOfModifierCards deckOfModifierCards = deckFactory.CreateDeckOfModifierCards();

            listOfCards.AddRange(deckOfMonsterCards.ListOfCards);
            listOfCards.AddRange(deckOfModifierCards.ListOfCards);
        }
        #endregion
    }
}
