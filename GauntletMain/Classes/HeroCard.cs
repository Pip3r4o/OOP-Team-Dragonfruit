using System.Drawing;


namespace GauntletMain
{
    //name
    //art
    //health points
    //action points
    //coins

    //attack points (depending on the dice roll)
    //defense points
    //special ability

    public class HeroCard : Card
    {
        public HeroCard(string name, Image artImage, int healthPoints, int actionPoints, int coins, EntityStats stats)
            : base(name, artImage)
        {
            this.HealthPoints = healthPoints;
            this.ActionPoints = actionPoints;
            this.Coins = coins;
            this.Stats = stats;
        }

        public int HealthPoints { get; set; }

        public int ActionPoints { get; set; }

        public int Coins  { get; set; }

        public EntityStats Stats  { get; set; }

    }
}
