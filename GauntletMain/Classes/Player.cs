using System.Drawing;

namespace GauntletMain
{
    public class Player : GameObject
    {
        public Player(string name, Image artImage, int dice) 
            : base(name, artImage)
        {
            this.Dice = dice;
        }

        public int Dice
        {
            get; 
            set;
        }
    }
}
