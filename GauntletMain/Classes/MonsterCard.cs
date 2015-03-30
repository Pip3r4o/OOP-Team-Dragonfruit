using System.Drawing;

namespace TrialOfFortune.Classes
{
    public class MonsterCard : Encounter
    {

        public MonsterCard(string name, Image artImage, int damage, EntityStats stats, bool alive, int coinsAwarded)
            : base(name, artImage)
        {
            this.Damage = damage;
            this.Stats = stats;
            this.Alive = alive;
            this.CoinsAwarded = coinsAwarded;
        }

        public int Damage { get; set; }
        public EntityStats Stats { get; set; }
        public bool Alive { get; set; }
        public int CoinsAwarded { get; set; }

    }
}
