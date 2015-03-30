namespace TrialOfFortune.Classes
{
    public class Player : GameObject
    {
        private const int InitialDice = 2;
        private const int InitialHealthPoints = 4;

        public Player(string name, HeroCard hero, WeaponCard weapon, int totalAttackPoints, int totalDefensePoints, int totalActionPoints, int totalCoins, int turn) 
            : base(name)
        {
            this.CurrentHero = hero;
            this.CurrentWeapon = weapon;
            this.Dice = InitialDice;
            this.TotalHealthPoints = InitialHealthPoints;
            this.TotalAttackPoints = totalAttackPoints;
            this.TotalDefensePoints = totalDefensePoints;
            this.TotalActionPoints = totalActionPoints;
            this.TotalCoins = totalCoins;
            this.Turn = turn;
            this.UsedAbility = false;
        }

        static Player() 
        {
            ActivePlayer = new Player(null, null, null, 0, 0, 0, 0, 0);
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
        public int Turn { get; set; }
        public bool UsedAbility { get; set; }
    }
}
