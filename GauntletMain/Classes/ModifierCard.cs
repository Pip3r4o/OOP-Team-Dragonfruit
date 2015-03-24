using System.Drawing;

namespace GauntletMain.Classes
{
    public class ModifierCard : Encounter
    {

        public ModifierCard(string name, Image artImage, ModifierEvent modifierEvent)
            : base(name, artImage)
        {
            this.Event = modifierEvent;
        }

        public ModifierEvent Event { get; private set; }
    }
}
