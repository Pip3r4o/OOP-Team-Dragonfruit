namespace TrialOfFortune.Decks
{
    public class DeckFactory : IDeckFactory
    {
        public DeckOfHeroCards CreateDeckOfHeroCards()
        {
            return new DeckOfHeroCards();
        }

        public DeckOfWeaponCards CreateDeckOfWeaponCards()
        {
            return new DeckOfWeaponCards();
        }

        public DeckOfEncounterCards CreateDeckOfEncounterCards()
        {
            return new DeckOfEncounterCards();
        }

        public DeckOfMonsterCards CreateDeckOfMonsterCards()
        {
            return new DeckOfMonsterCards();
        }

        public DeckOfModifierCards CreateDeckOfModifierCards()
        {
            return new DeckOfModifierCards();
        }
    }
}
