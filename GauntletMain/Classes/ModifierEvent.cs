namespace TrialOfFortune.Classes
{

    public class ModifierEvent
    {
        private const int InitialHealthPoints = 4;

        public static void SpringTrap(Player player)
        {
            --player.TotalAttackPoints;
        }

        public static void HealingSpring(Player player)
        {
            if (player.TotalHealthPoints < InitialHealthPoints + player.CurrentHero.HealthPoints)
            {
                ++player.TotalHealthPoints;
            }
        }

        public static void TearSatchel(Player player)
        {
            if (player.TotalCoins >= 3)
            {
                player.TotalCoins -= 3;
            }
            else if (player.TotalCoins == 2)
            {
                player.TotalCoins -= 2;
            }
            else if (player.TotalCoins == 1)
            {
                --player.TotalCoins;
            }
        }

        public static void GoodFortune(Player player)
        {
            player.TotalCoins += 4;
        }

        public static void BearTrap(Player player)
        {
            --player.TotalDefensePoints;
        }
    }
}
