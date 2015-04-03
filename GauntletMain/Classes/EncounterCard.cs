using System.Drawing;

namespace TrialOfFortune.Classes
{
    public abstract class EncounterCard : Card
    {
        protected EncounterCard(string name, Image artImage)
            : base(name, artImage)
        {
        }

    }
}
