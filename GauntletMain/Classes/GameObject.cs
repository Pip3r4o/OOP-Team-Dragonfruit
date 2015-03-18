using System.Drawing;

namespace GauntletMain
{
    public abstract class GameObject
    {

        public GameObject(string name, Image artImage)
        {
            this.Name = name;
            this.ArtImage = artImage;
        }

        public string Name { get; set; }

        public Image ArtImage { get; set; }
        
    }
}
