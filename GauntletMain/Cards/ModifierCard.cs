using System.Drawing;
using TrialOfFortune.Classes;

namespace TrialOfFortune.Cards
{
    public class ModifierCard : EncounterCard, IModifier
    {

        public ModifierCard(string name, Image artImage, ModifierEventEnum modifierEvent)
            : base(name, artImage)
        {
            this.Event = modifierEvent;
        }

        public ModifierEventEnum Event { get; private set; }
    }
}
