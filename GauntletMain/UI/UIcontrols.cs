using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using TrialOfFortune.Classes;
using TrialOfFortune.Cards;

namespace TrialOfFortune
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
        public delegate void OnClick();
        public event OnClick click;

        public ImgContainer()
        {
            this.BackColor = Color.DeepSkyBlue;
            this.Size = new Size(173, 280);
        }

        public Card Card = null;
        public PlayerCard PlayerCard = null;

        public void ShowCard(Card card)
        {
            this.Card = card;
            this.Image = Card.ArtImage;  
        }

        public void ShowMiniCard(PlayerCard card)
        {
            this.PlayerCard = card;
            this.Image = card.MiniArtImage;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if(StaticResources.CurrentFightPhase == StaticResources.FightPhase.NA &&
                this.Card!=null &&
                this.Card.ArtImage!= null &&
                this.Card.ArtImage.Size.Height > 140
                ) click();
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
            this.BackColor = Color.Transparent;
            base.OnCreateControl();
        }
    }

}
