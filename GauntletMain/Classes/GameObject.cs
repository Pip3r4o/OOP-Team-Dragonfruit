using System.Drawing;

namespace GauntletMain.Classes
{
    public abstract class GameObject
    {

        protected GameObject(string name)
        {
            this.Name = name;
        }

        protected GameObject(string name, Image artImage) :this(name)
        {
            this.ArtImage = artImage;
        }


        public string Name { get; set; }

        public Image ArtImage { get; set; }
        
    }
}
