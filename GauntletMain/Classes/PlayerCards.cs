using System.Drawing;

namespace GauntletMain.Classes
{
    public abstract class PlayerCards : Card
    {
        protected PlayerCards(string name, Image artImage, Image miniArtImage, EntityStats stats)
            : base(name, artImage)
        {
            this.MiniArtImage = miniArtImage;
            this.Stats = stats;
        }

        public Image MiniArtImage { get; set; }
        public EntityStats Stats { get; set; }
    }
}
