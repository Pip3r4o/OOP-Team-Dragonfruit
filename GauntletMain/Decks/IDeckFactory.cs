namespace TrialOfFortune.Decks
{
    interface IDeckFactory
    {
        DeckOfHeroCards CreateDeckOfHeroCards();

        DeckOfWeaponCards CreateDeckOfWeaponCards();

        DeckOfEncounterCards CreateDeckOfEncounterCards();

        DeckOfMonsterCards CreateDeckOfMonsterCards();

        DeckOfModifierCards CreateDeckOfModifierCards();
    }
}
