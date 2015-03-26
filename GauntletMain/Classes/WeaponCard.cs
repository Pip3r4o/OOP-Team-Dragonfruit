using System.Drawing;

namespace GauntletMain.Classes
{
    public class WeaponCard : PlayerCards
    {
        public WeaponCard(string name, Image artImage, Image miniArtImage, int additionalDice, EntityStats stats)
            : base(name, artImage, miniArtImage, stats)
        {
            this.AdditionalDice = additionalDice;
        }

        public int AdditionalDice { get; set; }

    }
}
