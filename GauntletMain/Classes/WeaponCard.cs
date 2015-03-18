using System;
using System.Drawing;

namespace GauntletMain.Classes
{
    //name
    //art
    //additional dice

    //attack points
    //defense points
    //special ability (if present)
    [Serializable]
    public class WeaponCard : Card
    {
        public WeaponCard(string name, Image artImage, int additionalDice, EntityStats stats)
            : base(name, artImage)
        {
            this.AdditionalDice = additionalDice;
            this.Stats = stats;
        }

        public EntityStats Stats { get; set; }

        public int AdditionalDice { get; set; }

    }
}
