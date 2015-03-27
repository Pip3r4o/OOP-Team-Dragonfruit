using System.Drawing;

namespace GauntletMain.Classes
{
    public abstract class PlayerCard : Card
    {
        protected PlayerCard(string name, Image artImage, Image miniArtImage, EntityStats stats)
            : base(name, artImage)
        {
            this.MiniArtImage = miniArtImage;
            this.Stats = stats;
        }

        public Image MiniArtImage { get; set; }
        public EntityStats Stats { get; set; }
    }
}
