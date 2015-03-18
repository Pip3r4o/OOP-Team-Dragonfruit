using System.Drawing;

namespace GauntletMain
{
    public abstract class Card : GameObject
    {
        public Card(string name, Image artImage) 
            : base(name, artImage)
        {
        }
    }
}
