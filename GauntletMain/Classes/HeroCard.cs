using System.Drawing;

namespace GauntletMain.Classes
{
    public class HeroCard : Card
    {
        public HeroCard(string name, Image artImage, int healthPoints, int actionPoints, EntityStats stats)
            : base(name, artImage)
        {
            this.HealthPoints = healthPoints;
            this.ActionPoints = actionPoints;
            this.Stats = stats;
        }

        public int HealthPoints { get; private set; }

        public int ActionPoints { get; private set; }

        public EntityStats Stats  { get; set; }

    }
}
