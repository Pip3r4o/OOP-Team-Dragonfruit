using GauntletMain.Classes;

namespace GauntletMain.Decks
{
    class DeckOfEncounterCards : Deck<Encounter>
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
