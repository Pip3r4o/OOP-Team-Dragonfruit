using System;
using System.Windows.Forms;
using GauntletMain.Classes;
using GauntletMain.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace GauntletMain
{
    public partial class GameForm : GameUIForm
    {
        public GameForm()
        {
            InitializeComponent();

            //int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            //style |= NativeWinAPI.WS_EX_COMPOSITED;
            //NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            heroImgContainer1.click += PlayOnClick;
            heroImgContainer2.click += PlayOnClick;
            heroImgContainer3.click += PlayOnClick;

            weaponImgContainer1.click += PlayOnClick;
            weaponImgContainer2.click += PlayOnClick;
            weaponImgContainer3.click += PlayOnClick;

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
                MessageBox.Show("Invalid name!", "Invalid Name!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                Player.ActivePlayer.Name = tbxName1.Text;
            }

            if (playerHeroImgContainer.Image == null || playerWeaponImgContainer.Image == null)
            {
                MessageBox.Show("You must first choose a Hero and a Weapon to play with!", "Invalid Choice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        FightButton.BackgroundImage = AssetsUI.DeffendButton;
                        SpecialButton.Hide();
                    }
                    break;
                case StaticResources.FightPhase.Defend:
                    {
                        StaticResources.CurrentFightPhase = StaticResources.FightPhase.NA;
                        Defend(Player.ActivePlayer, (MonsterCard)encounterImgContainer.Card);
                        FightButton.BackgroundImage = AssetsUI.AttackButton;
                        FightButton.Hide();
                        ContinueButton.Show();
                    }
                    break;
            }
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            if (encounterImgContainer.Card is MonsterCard)
            {
                SpecialFade(Player.ActivePlayer, (MonsterCard)encounterImgContainer.Card);
            }

            ContinueButton.Hide();
            DrawCard();
            DetermineEncounter();
        }

        private void SpecialButton_Click(object sender, EventArgs e)
        {
            if (Player.ActivePlayer.TotalActionPoints > 0)
            {
                switch (Player.ActivePlayer.CurrentHero.Stats.SpecialAbility)
                {
                    case AbilityEnum.Charge:
                        {
                            Ability.Charge(Player.ActivePlayer);
                            MessageBox.Show("You feel empowered and gain 5 Attack Points for the duration of this turn!", "Used special ability", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    case AbilityEnum.BushSkull:
                        {
                            Ability.BashSkull(Player.ActivePlayer, (MonsterCard)encounterImgContainer.Card);
                            MessageBox.Show(string.Format("You swing your {0} and break {1}'s skull.\nYou find {2} coins!", Player.ActivePlayer.CurrentWeapon.Name, ((MonsterCard)encounterImgContainer.Card).Name, ((MonsterCard)encounterImgContainer.Card).CoinsAwarded), "Used special ability", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    case AbilityEnum.EvasiveFire:
                        {
                            Ability.EvasiveFire(Player.ActivePlayer);
                            MessageBox.Show("You feel threatened and decide to not encounter the monster!", "Used special ability", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    case AbilityEnum.GoldRush:
                        {
                            Ability.GoldRush(Player.ActivePlayer);
                            MessageBox.Show("You are feeling lucky!", "Used special ability", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    case AbilityEnum.NatureCall:
                        {
                            Ability.NatureCall(Player.ActivePlayer);
                            MessageBox.Show("You channel nature's power and gain 4 Attack Points for the duration of this turn!", "Used special ability", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    case AbilityEnum.SummonSkeleton:
                        {
                            Ability.SummonSkeleton(Player.ActivePlayer);
                            MessageBox.Show("You summon a bony minion to protect you, thus granting you 4 Defence Points for the duration of this turn!", "Used special ability", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                }

                UpdateInformation();

                switch (StaticResources.CurrentFightPhase)
                {
                    case StaticResources.FightPhase.NA:
                        {
                            SpecialButton.Hide();
                            FightButton.Hide();
                            ContinueButton.Show();
                        }
                        break;
                    case StaticResources.FightPhase.Fight:
                        {
                            SpecialButton.Hide();
                            FightButton.Show();
                            ContinueButton.Hide();
                        }
                        break;
                    case StaticResources.FightPhase.Defend:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Insufficient amount of Action Points!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SpecialFade(Player player, MonsterCard card)
        {
            if (player.UsedAbility)
            {
                switch (player.CurrentHero.Stats.SpecialAbility)
                {
                    case AbilityEnum.Charge:
                        {
                            Ability.ChargeFade(player);
                        }
                        break;
                    case AbilityEnum.SummonSkeleton:
                        {
                            Ability.SummonSkeletonFade(player);
                        }
                        break;
                    case AbilityEnum.NatureCall:
                        {
                            Ability.NatureCallFade(player);
                        }
                        break;
                    case AbilityEnum.GoldRush:
                        {
                            Ability.GoldRushFade(player, card);
                        }
                        break;
                }
                player.UsedAbility = false;
                UpdateInformation();
            }
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
            Highscore score = new Highscore( Player.ActivePlayer.Name, Player.ActivePlayer.TotalCoins);

            score.WriteScore("..//..//scores.txt");
            List<Highscore.Record> results =  score.ReadScoresFromFile("..//..//scores.txt");
            results = results.OrderByDescending(x => x.Score).ToList();

            Form f = new Form();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Text = "GAME OVER! High Scores";

            ListBox lis = new ListBox();            
            lis.Dock = DockStyle.Fill;
            foreach (var x in results) lis.Items.Add("Player: "+x.Name + " Score: " + x.Score);
            f.Controls.Add(lis);
            f.ShowDialog();

            tabCtrlGame1.TabPages.Clear();
            tabCtrlGame1.TabPages.Add(tabPage3);
        }


    }
}
