using System;
using System.Windows.Forms;

namespace GauntletMain.Classes
{
    /// <summary>
    /// This is a placeholder class where methods are held temporarily until their true purpose is revealed :D
    /// </summary>

    class EncounterEngine
    {
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

        public static void Attack(Player player, MonsterCard monster)
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
        }

        public static void Defend(Player player, MonsterCard monster)
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
        }

        public static void DetermineEncounter(Player player, Encounter card)
        {
            if (card.GetType().ToString().TrimStart("GauntletMain.Classes.".ToCharArray()) == "MonsterCard")
            {
                //Activate "FIGHT!" button!
                //Treat encounter as Monster
            }
            else
            {
                //ActivateModifier(player, (ModifierCard)card);
                //Replace "FIGHT!" button with "Continue!"
                //call method of the relevant modifier card through switch case
            }
        }

        public static void ActivateModifier(Player player, ModifierCard card)
        {
            switch (card.Event)
            {
                case ModifierEventEnum.SpringTrap: ModifierEvent.SpringTrap(player);
                    MessageBox.Show(
                        string.Format("You sprung an arrow trap!\nYou are debilitated and thus lose 1 Attack point!"));
                    break;
                case ModifierEventEnum.HealingSpring: ModifierEvent.HealingSpring(player);
                    MessageBox.Show(
                        string.Format("You found a pond of fresh water!\nYou are restored 1 Health point!"));
                    break;
                case ModifierEventEnum.TearSatchel: ModifierEvent.TearSatchel(player);
                    MessageBox.Show(
                        string.Format("You find out that your pouch has been torn!\nYou have lost 3 coins!"));
                    break;
                case ModifierEventEnum.GoodFortune: ModifierEvent.GoodFortune(player);
                    MessageBox.Show(
                        string.Format("It's your lucky day!\nYou find 4 coins laying by a long-dead adventurer!"));
                    break;
                case ModifierEventEnum.BearTrap: ModifierEvent.BearTrap(player);
                    MessageBox.Show(
                        string.Format("You step into a bear trap!\nYou are weakened and thus lose 1 Defense point!"));
                    break;
            }
        }
    }
}
