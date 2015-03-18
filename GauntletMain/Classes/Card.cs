using System;
using System.Drawing;

namespace GauntletMain.Classes
{
    [Serializable]
    public abstract class Card : GameObject
    {
        protected Card(string name, Image artImage) 
            : base(name, artImage)
        {
        }
    }
}
