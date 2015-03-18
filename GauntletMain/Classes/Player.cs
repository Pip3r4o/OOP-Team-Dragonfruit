using System.Drawing;

namespace GauntletMain.Classes
{
    public class Player : GameObject
    {
        public Player(string name, Image artImage, int dice, int totalHealthPoints, int totalAttackPoints, int totalDefensePoints, int totalActionPoints, int totalCoins) 
            : base(name, artImage)
        {
            this.Dice = dice;
            this.TotalHealthPoints = totalHealthPoints;
            this.TotalAttackPoints = totalAttackPoints;
            this.TotalDefensePoints = totalDefensePoints;
            this.TotalActionPoints = totalActionPoints;
            this.TotalCoins = totalCoins;
        }

        public int Dice { get; set; }
        public int TotalHealthPoints { get; set; }
        public int TotalAttackPoints { get; set; }
        public int TotalDefensePoints { get; set; }
        public int TotalActionPoints { get; set; }
        public int TotalCoins { get; set; }
    }
}
