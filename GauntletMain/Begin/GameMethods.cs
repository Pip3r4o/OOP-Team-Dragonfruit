using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using GauntletMain.Classes;
using GauntletMain.Decks;

namespace GauntletMain
{
    /// <summary>
    /// Below is a mere mock-up methods for loading the cards. 
    /// They will not be loaded like this, and will have a proper class called DECK, which would hold them, and which will have the Shuffle method
    /// </summary>

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

            //Hides the tab headers
            tabCtrlGame1.Appearance = TabAppearance.FlatButtons;
            tabCtrlGame1.ItemSize = new Size(0, 1);
            tabCtrlGame1.SizeMode = TabSizeMode.Fixed;

            //Shows the First tab - the cards for choices of hero and weapon
            tabCtrlGame1.TabPages.Clear();
            tabCtrlGame1.TabPages.Add(tabPage1);
            btnGame1.Show();

            //Shuffle
            deckOfHeroCards.Shuffle();
            deckOfWeaponCards.Shuffle();
            deckOfEncounterCards.Shuffle();

            //Show the last three Hero Cards in the choices positions
            imgContHero1.ShowCard(deckOfHeroCards[deckOfHeroCards.Count() - 1]);
            labGame14.Text = deckOfHeroCards[deckOfHeroCards.Count() - 1].Name;
            imgContHero2.ShowCard(deckOfHeroCards[deckOfHeroCards.Count() - 2]);
            labGame15.Text = deckOfHeroCards[deckOfHeroCards.Count() - 2].Name;
            imgContHero3.ShowCard(deckOfHeroCards[deckOfHeroCards.Count() - 3]);
            labGame16.Text = deckOfHeroCards[deckOfHeroCards.Count() - 3].Name;

            imgContainer4.ShowCard(deckOfWeaponCards[deckOfWeaponCards.Count() - 1]);
            labGame17.Text = deckOfWeaponCards[deckOfWeaponCards.Count() - 1].Name;
            imgContainer5.ShowCard(deckOfWeaponCards[deckOfWeaponCards.Count() - 2]);
            labGame18.Text = deckOfWeaponCards[deckOfWeaponCards.Count() - 2].Name;
            imgContainer6.ShowCard(deckOfWeaponCards[deckOfWeaponCards.Count() - 3]);
            labGame19.Text = deckOfWeaponCards[deckOfWeaponCards.Count() - 3].Name;


            labGame8.Text = Player.ActivePlayer.TotalHealthPoints.ToString();
            labGame9.Text = Player.ActivePlayer.Dice.ToString();
            labGame10.Text = Player.ActivePlayer.TotalAttackPoints.ToString();
            labGame11.Text = Player.ActivePlayer.TotalDefensePoints.ToString();
            labGame12.Text = Player.ActivePlayer.TotalActionPoints.ToString();
            labGame13.Text = Player.ActivePlayer.TotalCoins.ToString();


        }

        public static int RollDice(int dice)
        {
            int atk = 0;
            Random rng = new Random();

            for (int i = 0; i < dice; i++)
            {
                atk += rng.Next(1, 7);
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
                    string.Format("You rolled {0} for a total of {1} attack!\nYou vanquished {2} and won {3} coins!",
                        currentRoll, totalAtk, monster.Name, monster.CoinsAwarded));

                player.TotalCoins += monster.CoinsAwarded;
                monster.Alive = false;
            }
            else
            {
                MessageBox.Show(
                    string.Format("You rolled {0} for a total of {1} attack!\nUnfortunately you did not manage to defeat {2}!",
                        currentRoll, totalAtk, monster.Name));
            }

            UpdateInformation(Player.ActivePlayer);
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
                MessageBox.Show(string.Format("You successfully dodged {0}'s attack!", monster.Name));
            }

            UpdateInformation(Player.ActivePlayer);
        }

        //TODO: Complete method
        public void DetermineEncounter(Encounter card)
        {
            if (card.GetType().ToString().TrimStart("GauntletMain.Classes.".ToCharArray()) == "MonsterCard")
            {
                btnGame3.Show();
                StaticResources.CurrentFightPhase = StaticResources.FightPhase.Fight;
                //btnGame3.BackgroundImage =;
                
            }
            else
            {
                btnGame3.Hide();
                StaticResources.CurrentFightPhase = StaticResources.FightPhase.NA;
                ActivateModifier(Player.ActivePlayer, (ModifierCard)card);

                UpdateInformation(Player.ActivePlayer);
                btnGame4.Hide();
                //Replace "FIGHT!" button with "Continue!"
            }
        }

        public static void ActivateModifier(Player player, ModifierCard card)
        {
            switch (card.Event)
            {
                case ModifierEventEnum.SpringTrap: ModifierEvent.SpringTrap(player);
                    MessageBox.Show(
                        string.Format("You sprung an arrow trap!\nYou are debilitated and thus lose 1 Attack point!"), "Spring Trap");
                    break;
                case ModifierEventEnum.HealingSpring: ModifierEvent.HealingSpring(player);
                    MessageBox.Show(
                        string.Format("You found a pond of fresh water!\nYou are restored 1 Health point!"), "Healing Spring");
                    break;
                case ModifierEventEnum.TearSatchel: ModifierEvent.TearSatchel(player);
                    MessageBox.Show(
                        string.Format("You find out that your pouch has been torn!\nYou have lost 3 coins!"), "Thorn Satchel");
                    break;
                case ModifierEventEnum.GoodFortune: ModifierEvent.GoodFortune(player);
                    MessageBox.Show(
                        string.Format("It's your lucky day!\nYou find 4 coins laying by a long-dead adventurer!"), "Good Fortune");
                    break;
                case ModifierEventEnum.BearTrap: ModifierEvent.BearTrap(player);
                    MessageBox.Show(
                        string.Format("You step into a bear trap!\nYou are crippled and thus lose 1 Defense point!"), "Bear Trap");
                    break;
            }
        }

        public void UpdateInformation(Player player)
        {
            labGame8.Text = (Player.ActivePlayer.TotalHealthPoints).ToString();
            labGame9.Text = (Player.ActivePlayer.Dice).ToString();
            labGame10.Text = (Player.ActivePlayer.TotalAttackPoints).ToString();
            labGame11.Text = (Player.ActivePlayer.TotalDefensePoints).ToString();
            labGame12.Text = (Player.ActivePlayer.TotalActionPoints).ToString();
            labGame13.Text = (Player.ActivePlayer.TotalCoins).ToString();
        }
        
    }
}
