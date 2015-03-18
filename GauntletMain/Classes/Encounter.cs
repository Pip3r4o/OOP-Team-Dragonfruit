using System;
using System.Drawing;

namespace GauntletMain.Classes
{
    [Serializable]
    public abstract class Encounter : Card
    {
        protected Encounter(string name, Image artImage)
            : base(name, artImage)
        {
        }

    }
}
