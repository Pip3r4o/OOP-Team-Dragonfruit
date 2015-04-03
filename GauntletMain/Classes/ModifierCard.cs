using System.Drawing;

namespace TrialOfFortune.Classes
{
    public class ModifierCard : EncounterCard
    {

        public ModifierCard(string name, Image artImage, ModifierEventEnum modifierEvent)
            : base(name, artImage)
        {
            this.Event = modifierEvent;
        }

        public ModifierEventEnum Event { get; private set; }
    }
}
