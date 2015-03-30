using System.Drawing;
using System.Windows.Forms;
using TrialOfFortune.Classes;
using TrialOfFortune.Decks;
using TrialOfFortune.Utilities;

namespace TrialOfFortune
{
    public partial class GameForm
    {
        DeckOfHeroCards deckOfHeroCards = new DeckOfHeroCards();
        DeckOfWeaponCards deckOfWeaponCards = new DeckOfWeaponCards();
        DeckOfEncounterCards deckOfEncounterCards = new DeckOfEncounterCards();

        //Game begins here
        public void  BeginNewGame()
        {

            //play Background music
            //StaticResources.wmp.URL = @"C:\Users\lachkov\Desktop\DragonFruit\oop-team-dragonfruit\GauntletMain\Sounds\Du Hast.mp3";
            //StaticResources.wmp.controls.play();
            //StaticResources.wmp.settings.volume = 50;

            heroImgContainer1.click += PlayOnClick;
            heroImgContainer2.click += PlayOnClick;
            heroImgContainer3.click += PlayOnClick;

            weaponImgContainer1.click += PlayOnClick;
            weaponImgContainer2.click += PlayOnClick;
            weaponImgContainer3.click += PlayOnClick;

            //Hides the tab headers
            tabCtrlGame1.Appearance = TabAppearance.FlatButtons;
            tabCtrlGame1.ItemSize = new Size(0, 1);
            tabCtrlGame1.SizeMode = TabSizeMode.Fixed;

            //Shows the First tab - the cards for choices of hero and weapon
            tabCtrlGame1.TabPages.Clear();
            tabCtrlGame1.TabPages.Add(tabPage1);
            PlayButton.Show();

            //Shuffle
            deckOfHeroCards.Shuffle();
            deckOfWeaponCards.Shuffle();
            deckOfEncounterCards.Shuffle();

            //Resets the player statistics
            Player.ActivePlayer = new Player(null, null, null, 0, 0, 0, 0, 0);

            //Show the last three Hero Cards in the choices positions
            heroImgContainer1.ShowCard(deckOfHeroCards[deckOfHeroCards.Count() - 1]);
            labGame14.Text = deckOfHeroCards[deckOfHeroCards.Count() - 1].Name;
            heroImgContainer2.ShowCard(deckOfHeroCards[deckOfHeroCards.Count() - 2]);
            labGame15.Text = deckOfHeroCards[deckOfHeroCards.Count() - 2].Name;
            heroImgContainer3.ShowCard(deckOfHeroCards[deckOfHeroCards.Count() - 3]);
            labGame16.Text = deckOfHeroCards[deckOfHeroCards.Count() - 3].Name;

            weaponImgContainer1.ShowCard(deckOfWeaponCards[deckOfWeaponCards.Count() - 1]);
            labGame17.Text = deckOfWeaponCards[deckOfWeaponCards.Count() - 1].Name;
            weaponImgContainer2.ShowCard(deckOfWeaponCards[deckOfWeaponCards.Count() - 2]);
            labGame18.Text = deckOfWeaponCards[deckOfWeaponCards.Count() - 2].Name;
            weaponImgContainer3.ShowCard(deckOfWeaponCards[deckOfWeaponCards.Count() - 3]);
            labGame19.Text = deckOfWeaponCards[deckOfWeaponCards.Count() - 3].Name;

            labGame8.Text = Player.ActivePlayer.TotalHealthPoints.ToString();
            labGame9.Text = Player.ActivePlayer.Dice.ToString();
            labGame10.Text = Player.ActivePlayer.TotalAttackPoints.ToString();
            labGame11.Text = Player.ActivePlayer.TotalDefensePoints.ToString();
            labGame12.Text = Player.ActivePlayer.TotalActionPoints.ToString();
            labGame13.Text = Player.ActivePlayer.TotalCoins.ToString();

        }

        private void DrawCard()
        {
            ++Player.ActivePlayer.Turn;
            encounterImgContainer.ShowCard(deckOfEncounterCards[deckOfEncounterCards.Count() - Player.ActivePlayer.Turn]);
        }

        public int RollDice(int dice)
        {
            int atk = 0;

            for (int i = 0; i < dice; i++)
            {
                atk += ThreadSafeRandom.ThisThreadsRandom.Next(1, 7);
            }

            return atk;
        }

        public void Attack(Player player, MonsterCard monster)
        {
            int currentRoll = RollDice(player.Dice);
            int totalAtk = currentRoll + player.TotalAttackPoints;

            if (totalAtk >= monster.Stats.DefensePoints)
            {
                MessageBox.Show(
                    string.Format("You rolled {0} for a total of {1} attack!\n\nYou vanquished {2} and won {3} coins!",
                        currentRoll, totalAtk, monster.Name, monster.CoinsAwarded));

                player.TotalCoins += monster.CoinsAwarded;
                monster.Alive = false;
            }
            else
            {
                MessageBox.Show(
                    string.Format("You rolled {0} for a total of {1} attack!\n\nUnfortunately you did not manage to defeat {2}!",
                        currentRoll, totalAtk, monster.Name));
            }

            UpdateInformation();
        }

        public void Defend(Player player, MonsterCard monster)
        {
            if (monster.Stats.AttackPoints > player.TotalDefensePoints)
            {
                MessageBox.Show(string.Format("{0} hit you! You lose {1} health point(s)!", monster.Name, monster.Damage));
                player.TotalHealthPoints -= monster.Damage;
            }
            else
            {
                MessageBox.Show(string.Format("Your defense is greater than {0}'s attack.\n\nYou successfully dodged {0}'s attempt to strike you!", monster.Name));
            }

            UpdateInformation();
        }

        public void DetermineEncounter()
        {
            Encounter card = (Encounter)encounterImgContainer.Card;

            if (card is MonsterCard)
            {
                ContinueButton.Hide();
                FightButton.Show();
                SpecialButton.Show();
                StaticResources.CurrentFightPhase = StaticResources.FightPhase.Fight;
            }
            else
            {
                FightButton.Hide();
                SpecialButton.Hide();
                StaticResources.CurrentFightPhase = StaticResources.FightPhase.NA;
                ActivateModifier(Player.ActivePlayer, (ModifierCard)card);
                UpdateInformation();
                ContinueButton.Show();
            }
        }

        public void ActivateModifier(Player player, ModifierCard card)
        {
            switch (card.Event)
            {
                case ModifierEventEnum.SpringTrap: ModifierEvent.SpringTrap(player);
                    MessageBox.Show(
                        string.Format("You sprung an arrow trap!\n\nYou are debilitated and thus lose 1 Attack point!"), card.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case ModifierEventEnum.HealingSpring: ModifierEvent.HealingSpring(player);
                    MessageBox.Show(
                        string.Format("You found a pond of fresh water!\n\nYou are restored 1 Health point!"), card.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case ModifierEventEnum.TearSatchel: ModifierEvent.TearSatchel(player);
                    MessageBox.Show(
                        string.Format("You find out that your pouch has been torn!\n\nYou have lost 3 coins!"), card.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case ModifierEventEnum.GoodFortune: ModifierEvent.GoodFortune(player);
                    MessageBox.Show(
                        string.Format("It's your lucky day!\n\nYou find 4 coins laying by a long-dead adventurer!"), card.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case ModifierEventEnum.BearTrap: ModifierEvent.BearTrap(player);
                    MessageBox.Show(
                        string.Format("You step into a bear trap!\n\nYou are crippled and thus lose 1 Defense point!"), card.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        public void PlayOnClick()
        {
            StaticResources.sp = new System.Media.SoundPlayer(AssetsSounds.ChooseCard);
            StaticResources.sp.Play();
        }
        
    }
}
