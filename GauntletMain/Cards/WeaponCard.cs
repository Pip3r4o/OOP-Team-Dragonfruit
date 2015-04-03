using System.Drawing;
using TrialOfFortune.Classes;

namespace TrialOfFortune.Cards
{
    public class WeaponCard : PlayerCard
    {
        public WeaponCard(string name, Image artImage, Image miniArtImage, int additionalDice, EntityStats stats)
            : base(name, artImage, miniArtImage, stats)
        {
            this.AdditionalDice = additionalDice;
        }

        public int AdditionalDice { get; set; }

    }
}
