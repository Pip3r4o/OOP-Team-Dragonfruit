using System.Drawing;

namespace TrialOfFortune.Cards
{
    public abstract class EncounterCard : Card
    {
        protected EncounterCard(string name, Image artImage)
            : base(name, artImage)
        {
        }

    }
}
