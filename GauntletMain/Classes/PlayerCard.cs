using System.Drawing;

namespace TrialOfFortune.Classes
{
    public abstract class PlayerCard : Card, IFightable
    {
        protected PlayerCard(string name, Image artImage, Image miniArtImage, EntityStats stats)
            : base(name, artImage)
        {
            this.Stats = stats;

            this.MiniArtImage = miniArtImage;
        }

        public EntityStats Stats { get; set; }

        public Image MiniArtImage { get; set; }
    }
}
