using TrialOfFortune.Classes;
using TrialOfFortune.Cards;

namespace TrialOfFortune.Decks
{
    class DeckOfEncounterCards : Deck<EncounterCard>
    {
        #region Constructors
        public DeckOfEncounterCards()
        {
            DeckOfMonsterCards deckOfMonsterCards = new DeckOfMonsterCards();
            DeckOfModifierCards deckOfModifierCards = new DeckOfModifierCards();

            listOfCards.AddRange(deckOfMonsterCards.ListOfCards);
            listOfCards.AddRange(deckOfModifierCards.ListOfCards);
        }
        #endregion
    }
}
