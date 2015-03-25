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
    /// <summary>
    /// Below is a mere mock-up methods for loading the cards. 
    /// They will not be loaded like this, and will have a proper class called DECK, which would hold them, and which will have the Shuffle method
    /// </summary>

    public partial class GameForm
    {
        //Here begins the game
        public void BeginNewGame()
        {

            //play Background music
            //StaticResources.wmp.URL = @"C:\Users\lachkov\Desktop\DragonFruit\oop-team-dragonfruit\GauntletMain\Sounds\Du Hast.mp3";
            //StaticResources.wmp.controls.play();
            //StaticResources.wmp.settings.volume = 50;

            //Hides the tab headers
            tabCtrlGame1.Appearance = TabAppearance.FlatButtons;
            tabCtrlGame1.ItemSize = new Size(0, 1);
            tabCtrlGame1.SizeMode = TabSizeMode.Fixed;

            //Shows the First tab - the cards for choices of hero and weapon
            tabCtrlGame1.TabPages.Clear();
            tabCtrlGame1.TabPages.Add(tabPage1);

            //Load the list with the HeroCards - should be a Deck - TO DO!
            CardGenerator.CreateHeroCard();
            var listOfHeroCards = CardGenerator.ListOfHeroes;
            CardGenerator.CreateWeaponCard();
            var listOfWeaponCards = CardGenerator.ListOfWeapons;

            //Shuffle ... to DO!!!


            //Show the last three Hero Cards in the choices positions
            imgContHero1.ShowCard(listOfHeroCards[listOfHeroCards.Count() - 1]);
            labGame14.Text = listOfHeroCards[listOfHeroCards.Count() - 1].Name;
            imgContHero2.ShowCard(listOfHeroCards[listOfHeroCards.Count() - 2]);
            labGame15.Text = listOfHeroCards[listOfHeroCards.Count() - 2].Name;
            imgContHero3.ShowCard(listOfHeroCards[listOfHeroCards.Count() - 3]);
            labGame16.Text = listOfHeroCards[listOfHeroCards.Count() - 3].Name;

            imgContainer4.ShowCard(listOfWeaponCards[listOfWeaponCards.Count() - 1]);
            labGame17.Text = listOfWeaponCards[listOfWeaponCards.Count() - 1].Name;
            imgContainer5.ShowCard(listOfWeaponCards[listOfWeaponCards.Count() - 2]);
            labGame18.Text = listOfWeaponCards[listOfWeaponCards.Count() - 2].Name;
            imgContainer6.ShowCard(listOfWeaponCards[listOfWeaponCards.Count() - 3]);
            labGame19.Text = listOfWeaponCards[listOfWeaponCards.Count() - 3].Name;

        }
    }
}
