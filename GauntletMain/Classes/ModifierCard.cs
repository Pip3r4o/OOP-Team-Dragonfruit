using System.Drawing;

namespace GauntletMain.Classes
{
    public class ModifierCard : Encounter
    {

        public ModifierCard(string name, Image artImage, ModifierEventEnum modifierEvent)
            : base(name, artImage)
        {
            this.Event = modifierEvent;
        }

        public ModifierEventEnum Event { get; private set; }
    }
}
