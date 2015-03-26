using System.Drawing;

namespace GauntletMain.Classes
{
    public class HeroCard : PlayerCards
    {
        public HeroCard(string name, Image artImage, Image miniArtImage, int healthPoints, int actionPoints, EntityStats stats)
            : base(name, artImage, miniArtImage, stats)
        {
            this.HealthPoints = healthPoints;
            this.ActionPoints = actionPoints;
        }

        public int HealthPoints { get; private set; }

        public int ActionPoints { get; private set; }

    }
}
