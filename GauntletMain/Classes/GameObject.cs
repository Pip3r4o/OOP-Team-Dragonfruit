using System.Drawing;

namespace GauntletMain.Classes
{
    public abstract class GameObject
    {

        protected GameObject(string name, Image artImage)
        {
            this.Name = name;
            this.ArtImage = artImage;
        }

        public string Name { get; set; }

        public Image ArtImage { get; set; }
        
    }
}
