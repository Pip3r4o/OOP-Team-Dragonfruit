namespace GauntletMain.Classes
{
    public enum ModifierEventEnum { SpringTrap, HealingSpring, TearSatchel, GoodFortune, BarbedWireTrap}

    public class ModifierEvent
    {
        public static void SpringTrap(Player player)
        {
            --player.TotalAttackPoints;
        }

        public static void HealingSpring(Player player)
        {
            if (player.TotalHealthPoints != 5)
            {
                ++player.TotalHealthPoints;
            }
        }

        public static void TearSatchel(Player player)
        {
            if (player.TotalCoins >= 3)
            {
                player.TotalCoins = player.TotalCoins - 3;
            }
            else if (player.TotalCoins == 2)
            {
                player.TotalCoins = player.TotalCoins - 2;
            }
            else if (player.TotalCoins == 1)
            {
                --player.TotalCoins;
            }
        }

        public static void GoodFortune(Player player)
        {
            player.TotalCoins = player.TotalCoins + 4;
        }

        public static void BarbedWireTrap(Player player)
        {
            --player.TotalDefensePoints;
        }
    }
}
