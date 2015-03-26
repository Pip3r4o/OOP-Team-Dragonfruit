using System.Drawing;

namespace GauntletMain.Classes
{
    public class Player : GameObject
    {
        private const int InitialDice = 2;

        public Player(string name, HeroCard hero, WeaponCard weapon, int totalHealthPoints, int totalAttackPoints, int totalDefensePoints, int totalActionPoints, int totalCoins) 
            : base(name)
        {
            this.CurrentHero = hero;
            this.CurrentWeapon = weapon;
            this.Dice = weapon.AdditionalDice + InitialDice;
            this.TotalHealthPoints = totalHealthPoints;
            this.TotalAttackPoints = totalAttackPoints;
            this.TotalDefensePoints = totalDefensePoints;
            this.TotalActionPoints = totalActionPoints;
            this.TotalCoins = totalCoins;
        }


        public HeroCard CurrentHero { get; private set; }
        public WeaponCard CurrentWeapon { get; private set; }
        
        public int Dice { get; set; }
        public int TotalHealthPoints { get; set; }
        public int TotalAttackPoints { get; set; }
        public int TotalDefensePoints { get; set; }
        public int TotalActionPoints { get; set; }
        public int TotalCoins { get; set; }
    }
}
