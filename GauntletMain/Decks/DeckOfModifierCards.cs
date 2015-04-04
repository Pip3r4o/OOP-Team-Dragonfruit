using System.Collections.Generic;
using TrialOfFortune.Classes;
using TrialOfFortune.Cards;
using System.Drawing;

namespace TrialOfFortune.Decks
{
    public class DeckOfModifierCards : Deck<ModifierCard>
    {
        private const int NUMBER_OF_MODIFIER_CARDS = 5;
        private string[] names;
        private Image[] artImages;
        private ModifierEventEnum[] modifierEvents;

        #region Constructors
        public DeckOfModifierCards()
        {
            names = new string[NUMBER_OF_MODIFIER_CARDS]
            {
                "Spring Trap",
                "Healing Spring",
                "Tear Satchel",
                "Good Fortune",
                "Bear Trap"
            };

            artImages = new Image[NUMBER_OF_MODIFIER_CARDS]
            {
                AssetsModifiers.SPRINGTRAP,
                AssetsModifiers.HEALINGSPRING,
                AssetsModifiers.TEARSATCHEL,
                AssetsModifiers.GOODFORTUNE,
                AssetsModifiers.BEARTRAP
            };

            modifierEvents = new ModifierEventEnum[NUMBER_OF_MODIFIER_CARDS]
            {
            
              ModifierEventEnum.SpringTrap,
              ModifierEventEnum.HealingSpring,
              ModifierEventEnum.TearSatchel,
              ModifierEventEnum.GoodFortune,
              ModifierEventEnum.BearTrap
            };

            var modifierCards = new List<ModifierCard>();
            CardFactory cardFactory = new CardFactory();
            for (int i = 0; i < NUMBER_OF_MODIFIER_CARDS; i++)
            {
                modifierCards.Add(cardFactory.CreateModifierCard(names[i], artImages[i],modifierEvents[i]));
            }

            listOfCards.AddRange(modifierCards);
        }
        #endregion
    }
}
