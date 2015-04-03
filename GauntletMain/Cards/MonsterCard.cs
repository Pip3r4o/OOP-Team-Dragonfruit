using System.Drawing;

namespace TrialOfFortune.Cards
{
    public class MonsterCard : EncounterCard
    {

        public MonsterCard(string name, Image artImage, int damage, EntityStats stats, bool alive, int coinsAwarded)
            : base(name, artImage)
        {
            this.Stats = stats;

            this.Damage = damage;
            this.Alive = alive;
            this.CoinsAwarded = coinsAwarded;
        }

        public EntityStats Stats { get; private set; }

        public int Damage { get; private set; }

        public bool Alive { get; set; }
        
        public int CoinsAwarded { get; private set; }

    }
}
