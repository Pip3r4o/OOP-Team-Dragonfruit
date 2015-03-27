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
using GauntletMain.Decks;

namespace GauntletMain
{
    public partial class GameForm : GameUIForm
    {

        public GameForm()
        {
            InitializeComponent();
            BeginNewGame();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void imgContHero1_Click(object sender, EventArgs e)
        {
            UpdateInfoHero((HeroCard)imgContHero1.Card);
            UpdateTotalInfo((HeroCard)imgContainer7.PlayerCard, (WeaponCard)imgContainer8.PlayerCard);
        }

        private void imgContHero2_Click(object sender, EventArgs e)
        {
            UpdateInfoHero((HeroCard)imgContHero2.Card);
            UpdateTotalInfo((HeroCard)imgContainer7.PlayerCard, (WeaponCard)imgContainer8.PlayerCard);
        }

        private void imgContHero3_Click(object sender, EventArgs e)
        {
            UpdateInfoHero((HeroCard)imgContHero3.Card);
            UpdateTotalInfo((HeroCard)imgContainer7.PlayerCard, (WeaponCard)imgContainer8.PlayerCard);
        }

        private void imgContainer4_Click(object sender, EventArgs e)
        {
            UpdateInfoWeapon((WeaponCard)imgContainer4.Card);
            UpdateTotalInfo((HeroCard)imgContainer7.PlayerCard, (WeaponCard)imgContainer8.PlayerCard);
        }

        private void imgContainer5_Click(object sender, EventArgs e)
        {
            UpdateInfoWeapon((WeaponCard)imgContainer5.Card);
            UpdateTotalInfo((HeroCard)imgContainer7.PlayerCard, (WeaponCard)imgContainer8.PlayerCard);
        }

        private void imgContainer6_Click(object sender, EventArgs e)
        {
            UpdateInfoWeapon((WeaponCard)imgContainer6.Card);
            UpdateTotalInfo((HeroCard)imgContainer7.PlayerCard, (WeaponCard)imgContainer8.PlayerCard);
        }

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


            Player.ActivePlayer.Name = tbxName1.Text;
            Player.ActivePlayer.CurrentHero = (HeroCard)imgContainer7.PlayerCard;
            Player.ActivePlayer.CurrentWeapon = (WeaponCard)imgContainer8.PlayerCard;

            Player.ActivePlayer.TotalHealthPoints += Player.ActivePlayer.CurrentHero.HealthPoints;
            Player.ActivePlayer.Dice += Player.ActivePlayer.CurrentWeapon.AdditionalDice;
            Player.ActivePlayer.TotalAttackPoints += Player.ActivePlayer.CurrentHero.Stats.AttackPoints +
                                                     Player.ActivePlayer.CurrentWeapon.Stats.AttackPoints;
            Player.ActivePlayer.TotalDefensePoints += Player.ActivePlayer.CurrentHero.Stats.DefensePoints +
                                                    Player.ActivePlayer.CurrentWeapon.Stats.DefensePoints;
            Player.ActivePlayer.TotalActionPoints += Player.ActivePlayer.CurrentHero.ActionPoints;
            UpdateInformation(Player.ActivePlayer);

            tabCtrlGame1.TabPages.Clear();
            tabCtrlGame1.TabPages.Add(tabPage2);

            btnGame1.Hide();

            tbxName1.Enabled = false;

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

        private void UpdateInfoHero(HeroCard card)
        {
            labGame8.Text = (Player.ActivePlayer.TotalHealthPoints + card.HealthPoints).ToString();
            labGame10.Text = (Player.ActivePlayer.TotalAttackPoints + card.Stats.AttackPoints).ToString();
            labGame11.Text = (Player.ActivePlayer.TotalDefensePoints + card.Stats.DefensePoints).ToString();
            labGame12.Text = (Player.ActivePlayer.TotalActionPoints + card.ActionPoints).ToString();
            imgContainer7.ShowMiniCard(card);
        }

        private void UpdateInfoWeapon(WeaponCard card)
        {
            labGame9.Text = (Player.ActivePlayer.Dice + card.AdditionalDice).ToString();
            labGame10.Text = (Player.ActivePlayer.TotalAttackPoints + card.Stats.AttackPoints).ToString();
            labGame11.Text = (Player.ActivePlayer.TotalDefensePoints + card.Stats.DefensePoints).ToString();
            imgContainer8.ShowMiniCard(card);
        }

        private void UpdateTotalInfo(HeroCard heroCard, WeaponCard weaponCard)
        {
            if (heroCard != null && weaponCard != null)
            {
                labGame10.Text = (Player.ActivePlayer.TotalAttackPoints + heroCard.Stats.AttackPoints + weaponCard.Stats.AttackPoints).ToString();
                labGame11.Text = (Player.ActivePlayer.TotalDefensePoints + heroCard.Stats.DefensePoints + weaponCard.Stats.DefensePoints).ToString();
            }
        }



    }
}
