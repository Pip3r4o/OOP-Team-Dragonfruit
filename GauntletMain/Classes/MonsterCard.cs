using System.Drawing;

namespace TrialOfFortune.Classes
{
    public class MonsterCard : EncounterCard, IFightable
    {

        public MonsterCard(string name, Image artImage, int damage, EntityStats stats, bool alive, int coinsAwarded)
            : base(name, artImage)
        {
            this.Stats = stats;

            this.Damage = damage;
            this.Alive = alive;
            this.CoinsAwarded = coinsAwarded;
        }

        public EntityStats Stats { get; set; }

        public int Damage { get; set; }
        public bool Alive { get; set; }
        public int CoinsAwarded { get; set; }

    }
}
