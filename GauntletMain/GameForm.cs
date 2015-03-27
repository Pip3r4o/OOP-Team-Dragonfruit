using System;
using System.Windows.Forms;
using GauntletMain.Classes;

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

        private void heroImgContainer1_Click(object sender, EventArgs e)
        {
            UpdateInfoHero((HeroCard)heroImgContainer1.Card);
            UpdateTotalInfo((HeroCard)playerHeroImgContainer.PlayerCard, (WeaponCard)playerWeaponImgContainer.PlayerCard);
        }

        private void heroImgContainer2_Click(object sender, EventArgs e)
        {
            UpdateInfoHero((HeroCard)heroImgContainer2.Card);
            UpdateTotalInfo((HeroCard)playerHeroImgContainer.PlayerCard, (WeaponCard)playerWeaponImgContainer.PlayerCard);
        }

        private void heroImgContainer3_Click(object sender, EventArgs e)
        {
            UpdateInfoHero((HeroCard)heroImgContainer3.Card);
            UpdateTotalInfo((HeroCard)playerHeroImgContainer.PlayerCard, (WeaponCard)playerWeaponImgContainer.PlayerCard);
        }

        private void weaponImgContainer1_Click(object sender, EventArgs e)
        {
            UpdateInfoWeapon((WeaponCard)weaponImgContainer1.Card);
            UpdateTotalInfo((HeroCard)playerHeroImgContainer.PlayerCard, (WeaponCard)playerWeaponImgContainer.PlayerCard);
        }

        private void weaponImgContainer2_Click(object sender, EventArgs e)
        {
            UpdateInfoWeapon((WeaponCard)weaponImgContainer2.Card);
            UpdateTotalInfo((HeroCard)playerHeroImgContainer.PlayerCard, (WeaponCard)playerWeaponImgContainer.PlayerCard);
        }

        private void weaponImgContainer3_Click(object sender, EventArgs e)
        {
            UpdateInfoWeapon((WeaponCard)weaponImgContainer3.Card);
            UpdateTotalInfo((HeroCard)playerHeroImgContainer.PlayerCard, (WeaponCard)playerWeaponImgContainer.PlayerCard);
        }

        private void PlayButton_Click(object sender, EventArgs e)
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

            if (playerHeroImgContainer.Image == null || playerWeaponImgContainer.Image == null)
            {
                MessageBox.Show("You must first choose a Hero and a Weapon to play with!", "Invalid Choice!");
                return;
            }


            Player.ActivePlayer.Name = tbxName1.Text;
            Player.ActivePlayer.CurrentHero = (HeroCard)playerHeroImgContainer.PlayerCard;
            Player.ActivePlayer.CurrentWeapon = (WeaponCard)playerWeaponImgContainer.PlayerCard;

            Player.ActivePlayer.TotalHealthPoints += Player.ActivePlayer.CurrentHero.HealthPoints;
            Player.ActivePlayer.Dice += Player.ActivePlayer.CurrentWeapon.AdditionalDice;
            Player.ActivePlayer.TotalAttackPoints += Player.ActivePlayer.CurrentHero.Stats.AttackPoints +
                                                     Player.ActivePlayer.CurrentWeapon.Stats.AttackPoints;
            Player.ActivePlayer.TotalDefensePoints += Player.ActivePlayer.CurrentHero.Stats.DefensePoints +
                                                    Player.ActivePlayer.CurrentWeapon.Stats.DefensePoints;
            Player.ActivePlayer.TotalActionPoints += Player.ActivePlayer.CurrentHero.ActionPoints;
            UpdateInformation();
            ++Player.ActivePlayer.Turn;

            tabCtrlGame1.TabPages.Clear();
            tabCtrlGame1.TabPages.Add(tabPage2);
            PlayButton.Hide();
            tbxName1.Enabled = false;
 
            DrawCard();
            DetermineEncounter();
        }

        private void FightButton_Click(object sender, EventArgs e)
        {
            switch (StaticResources.CurrentFightPhase)
            {
                case StaticResources.FightPhase.NA:
                    break;
                case StaticResources.FightPhase.Fight:
                {
                    StaticResources.CurrentFightPhase = StaticResources.FightPhase.Defend;
                    Attack(Player.ActivePlayer, (MonsterCard)encounterImgContainer.Card);
                    //btnGame3.BackgroundImage =;
                    SpecialButton.Hide();
                }
                    break;
                case StaticResources.FightPhase.Defend:
                {
                    StaticResources.CurrentFightPhase = StaticResources.FightPhase.NA;
                    Defend(Player.ActivePlayer, (MonsterCard)encounterImgContainer.Card);
                    //btnGame3.BackgroundImage =;
                    FightButton.Hide();
                    ContinueButton.Show();
                }
                    break;
            }
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            ContinueButton.Hide();
            DrawCard();
            DetermineEncounter();
        }

        private void SpecialButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateInfoHero(HeroCard card)
        {
            labGame8.Text = (Player.ActivePlayer.TotalHealthPoints + card.HealthPoints).ToString();
            labGame10.Text = (Player.ActivePlayer.TotalAttackPoints + card.Stats.AttackPoints).ToString();
            labGame11.Text = (Player.ActivePlayer.TotalDefensePoints + card.Stats.DefensePoints).ToString();
            labGame12.Text = (Player.ActivePlayer.TotalActionPoints + card.ActionPoints).ToString();
            playerHeroImgContainer.ShowMiniCard(card);
        }

        private void UpdateInfoWeapon(WeaponCard card)
        {
            labGame9.Text = (Player.ActivePlayer.Dice + card.AdditionalDice).ToString();
            labGame10.Text = (Player.ActivePlayer.TotalAttackPoints + card.Stats.AttackPoints).ToString();
            labGame11.Text = (Player.ActivePlayer.TotalDefensePoints + card.Stats.DefensePoints).ToString();
            playerWeaponImgContainer.ShowMiniCard(card);
        }

        private void UpdateTotalInfo(HeroCard heroCard, WeaponCard weaponCard)
        {
            if (heroCard == null || weaponCard == null) return;

            labGame10.Text = (Player.ActivePlayer.TotalAttackPoints + heroCard.Stats.AttackPoints + weaponCard.Stats.AttackPoints).ToString();
            labGame11.Text = (Player.ActivePlayer.TotalDefensePoints + heroCard.Stats.DefensePoints + weaponCard.Stats.DefensePoints).ToString();
        }

        private void UpdateInformation()
        {
            labGame8.Text = (Player.ActivePlayer.TotalHealthPoints).ToString();
            labGame9.Text = (Player.ActivePlayer.Dice).ToString();
            labGame10.Text = (Player.ActivePlayer.TotalAttackPoints).ToString();
            labGame11.Text = (Player.ActivePlayer.TotalDefensePoints).ToString();
            labGame12.Text = (Player.ActivePlayer.TotalActionPoints).ToString();
            labGame13.Text = (Player.ActivePlayer.TotalCoins).ToString();

            //Check if player is alive
            if (StaticResources.CurrentFightPhase == StaticResources.FightPhase.NA)
            {
                if (Player.ActivePlayer.TotalHealthPoints <= 0)
                {
                    GameOver();
                }
            }
        }

        private void GameOver()
        {
            tabCtrlGame1.TabPages.Clear();
            tabCtrlGame1.TabPages.Add(tabPage3);
        }

        
    }
}
