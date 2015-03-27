using System.Drawing;
using System.Runtime.CompilerServices;

namespace GauntletMain.Classes
{
    public class Player : GameObject
    {
        private const int InitialDice = 2;
        public static Player activePlayer;

        public Player(string name, HeroCard hero, WeaponCard weapon, int totalHealthPoints, int totalAttackPoints, int totalDefensePoints, int totalActionPoints, int totalCoins) 
            : base(name)
        {
            this.CurrentHero = hero;
            this.CurrentWeapon = weapon;
            this.Dice = InitialDice;
            this.TotalHealthPoints = totalHealthPoints;
            this.TotalAttackPoints = totalAttackPoints;
            this.TotalDefensePoints = totalDefensePoints;
            this.TotalActionPoints = totalActionPoints;
            this.TotalCoins = totalCoins;
        }

        static Player() 
        {
            ActivePlayer = new Player(null, null, null, 4, 0, 0, 0, 0);
        }

        public static Player ActivePlayer { get; set; }
        public HeroCard CurrentHero { get; set; }
        public WeaponCard CurrentWeapon { get; set; }
        
        public int Dice { get; set; }
        public int TotalHealthPoints { get; set; }
        public int TotalAttackPoints { get; set; }
        public int TotalDefensePoints { get; set; }
        public int TotalActionPoints { get; set; }
        public int TotalCoins { get; set; }

    }
}
