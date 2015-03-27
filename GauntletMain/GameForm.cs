using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GauntletMain.Classes;

namespace GauntletMain
{
    public partial class GameForm : GameUIForm
    {//dimitar


        public GameForm()
        {
            InitializeComponent();
            BeginNewGame();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        #region OnClick events on start screen for Hero and Weapon Cards

        private void imgContHero1_Click(object sender, EventArgs e)
        {
            var heroCard = CardGenerator.ListOfHeroes;
            imgContainer7.ShowMiniCard(heroCard[heroCard.Count() - 1]);

        }

        private void imgContHero2_Click(object sender, EventArgs e)
        {
            var heroCard = CardGenerator.ListOfHeroes;
            labGame8.Text =
                (Player.ActivePlayer.TotalHealthPoints + heroCard[heroCard.Count() - 2].HealthPoints).ToString();
            imgContainer7.ShowMiniCard(heroCard[heroCard.Count() - 2]);
            labGame10.Text = (Player.ActivePlayer.TotalAttackPoints + heroCard[heroCard.Count() - 2].Stats.AttackPoints).ToString();
            labGame11.Text = (Player.ActivePlayer.TotalDefensePoints + heroCard[heroCard.Count() - 2].Stats.DefensePoints).ToString();
            labGame12.Text = (Player.ActivePlayer.TotalActionPoints + heroCard[heroCard.Count() - 2].ActionPoints).ToString();
            imgContainer7.ShowMiniCard(heroCard[heroCard.Count() - 2]);

        }

        private void imgContHero3_Click(object sender, EventArgs e)
        {
            var heroCard = CardGenerator.ListOfHeroes;
            imgContainer7.ShowMiniCard(heroCard[heroCard.Count() - 3]);
        }

        private void imgContainer4_Click(object sender, EventArgs e)
        {
            var weaponCard = CardGenerator.ListOfWeapons;
            imgContainer8.ShowMiniCard(weaponCard[weaponCard.Count() - 1]);
        }

        private void imgContainer5_Click(object sender, EventArgs e)
        {
            var weaponCard = CardGenerator.ListOfWeapons;
            imgContainer8.ShowMiniCard(weaponCard[weaponCard.Count() - 2]);
        }

        private void imgContainer6_Click(object sender, EventArgs e)
        {
            var weaponCard = CardGenerator.ListOfWeapons;
            imgContainer8.ShowMiniCard(weaponCard[weaponCard.Count() - 3]);
        }
        #endregion

        private void btnGame1_Click(object sender, EventArgs e)
        {
            if (!PlayerNameValidation.IsHostnameValid(tbxName1.Text))
            {
                MessageBox.Show("Invalid name!");
                return;

            }
            else
            {
                Player.ActivePlayer.Name = tbxName1.Text;
            }

            if (imgContainer7.Image == null || imgContainer8.Image == null)
            {
                MessageBox.Show("You must first choose a Hero and a Weapon to play with!", "Invalid Choice!");
                return;
            }



            Player.ActivePlayer.CurrentHero = (HeroCard)imgContainer7.PlayerCard;
            Player.ActivePlayer.CurrentWeapon = (WeaponCard)imgContainer8.PlayerCard;
            tabCtrlGame1.TabPages.Clear();
            tabCtrlGame1.TabPages.Add(tabPage2);

            btnGame1.Enabled = false;
            btnGame1.Hide();

            //SHUFFLE ENCOUNTER DECK
            //EncounterEngine.DetermineEncounter(encounter card)
        }

        private void btnGame3_Click(object sender, EventArgs e)
        {
            //TODO
            switch (StaticResources.CurrentFightPhase)
            {
                case StaticResources.FightPhase.NA:
                    break;
                case StaticResources.FightPhase.Fight:
                    break;
                case StaticResources.FightPhase.Defend:
                    break;
            }
        }






    }
}
