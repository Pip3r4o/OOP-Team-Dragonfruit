using System.Drawing;
using TrialOfFortune.Classes;

namespace TrialOfFortune.Cards
{
    public abstract class Card : GameObject
    {
        protected Card(string name, Image artImage) 
            : base(name, artImage)
        {
        }
    }
}
