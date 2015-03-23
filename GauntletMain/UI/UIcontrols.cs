using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using GauntletMain.Classes;

namespace GauntletMain
{

    public partial class GameUIForm : Form
    {
        public GameUIForm()
        {

        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }
    }

    public class TabCtrlGame : TabControl
    {
        public TabCtrlGame()
        {
           // this.Appearance = TabAppearance.FlatButtons;
           // this.ItemSize = new Size(0, 1);
           // this.SizeMode = TabSizeMode.Fixed;
            
        }

    }

    public class TabPageGame : TabPage
    {
        public TabPageGame()
        {
        }
        protected override void OnCreateControl()
        {
            this.BackColor = Color.White;
            base.OnCreateControl();
        }
    }

    public class ImgContainer : PictureBox
    {
        public ImgContainer()
        {
            this.BackColor = Color.DeepSkyBlue;
            this.Size = new Size(173, 280);
        }

        public HeroCard Card = null;

        public void ShowCard(HeroCard card)
        {
            this.Card = card;
            this.Image = Card.ArtImage;  
        }
    }

    public class tbxName : TextBox
    {
        public tbxName()
        {

        }

    }

    public class labGame : Label
    {
        public labGame()
        {

        }
    }

    public class btnGame : Button
    {
        public btnGame()
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }

        protected override void OnCreateControl()
        {
            this.BackColor = Color.Red;
            base.OnCreateControl();
        }
    }

}
