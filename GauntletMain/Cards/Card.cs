using System.Drawing;

namespace TrialOfFortune.Classes
{
    public abstract class Card : GameObject
    {
        protected Card(string name, Image artImage) 
            : base(name, artImage)
        {
        }
    }
}
