using System.Drawing;

namespace GauntletMain.Classes
{
    public abstract class Card : GameObject
    {
        protected Card(string name, Image artImage) 
            : base(name, artImage)
        {
        }
    }
}
