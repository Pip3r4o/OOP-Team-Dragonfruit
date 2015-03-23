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


    public partial class GameForm
    {
        //Here begins the game
        public void BeginNewGame()
        {
            //Hides the tab headers
             tabCtrlGame1.Appearance = TabAppearance.FlatButtons;
             tabCtrlGame1.ItemSize = new Size(0, 1);
             tabCtrlGame1.SizeMode = TabSizeMode.Fixed;

            //Shows the First tab - the cards for choices of hero and weapon
             tabCtrlGame1.TabPages.Clear();
             tabCtrlGame1.TabPages.Add(tabPage1);

            //Load the list with the HeroCards - should be a Deck - TO DO!
             var listOfHeroCards = CardLoader.LoadHeroCards();
            
            //Shuffle ... to DO!!!

            //Show the last three Hero Cards in the choices positions
             imgContHero1.ShowCard(listOfHeroCards[listOfHeroCards.Count() - 1]);
             imgContHero2.ShowCard(listOfHeroCards[listOfHeroCards.Count() - 2]);
             imgContHero3.ShowCard(listOfHeroCards[listOfHeroCards.Count() - 3]);


        }
    }
}
