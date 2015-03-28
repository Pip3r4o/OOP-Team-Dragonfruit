using System.Drawing;

namespace GauntletMain.Classes
{
    public abstract class Encounter : Card
    {
        protected Encounter(string name, Image artImage)
            : base(name, artImage)
        {
        }

    }
}
