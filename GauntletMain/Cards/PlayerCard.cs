using System.Drawing;

namespace TrialOfFortune.Cards
{
    public abstract class PlayerCard : Card
    {
        protected PlayerCard(string name, Image artImage, Image miniArtImage, EntityStats stats)
            : base(name, artImage)
        {
            this.Stats = stats;

            this.MiniArtImage = miniArtImage;
        }

        public EntityStats Stats { get; private set; }

        public Image MiniArtImage { get; private set; }
    }
}
