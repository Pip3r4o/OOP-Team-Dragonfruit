using System.Drawing;

namespace TrialOfFortune.Classes
{
    public abstract class Encounter : Card
    {
        protected Encounter(string name, Image artImage)
            : base(name, artImage)
        {
        }

    }
}
