using System.Collections.Generic;
using TrialOfFortune.Classes;

namespace TrialOfFortune.Decks
{
    class DeckOfModifierCards : Deck<ModifierCard>
    {
        #region Constructors
        public DeckOfModifierCards()
        {
            ModifierCard modifier1 = new ModifierCard("Spring Trap", AssetsModifiers.SPRINGTRAP, ModifierEventEnum.SpringTrap);
            ModifierCard modifier2 = new ModifierCard("Healing Spring", AssetsModifiers.HEALINGSPRING, ModifierEventEnum.HealingSpring);
            ModifierCard modifier3 = new ModifierCard("Tear Satchel", AssetsModifiers.TEARSATCHEL, ModifierEventEnum.TearSatchel);
            ModifierCard modifier4 = new ModifierCard("Good Fortune", AssetsModifiers.GOODFORTUNE, ModifierEventEnum.GoodFortune);
            ModifierCard modifier5 = new ModifierCard("Bear Trap", AssetsModifiers.BEARTRAP, ModifierEventEnum.BearTrap);

            listOfCards.AddRange(new List<ModifierCard>
                    {
                        modifier1,
                        modifier2,
                        modifier3,
                        modifier4,
                        modifier5
                    });
        }
        #endregion
    }
}
