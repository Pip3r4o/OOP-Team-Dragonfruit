using TrialOfFortune.Classes;

namespace TrialOfFortune.Cards
{
    public class EntityStats : IStats
    {
        public EntityStats(int attackPoints, int defensePoints)
        {
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
        }

        public EntityStats(int attackPoints, int defensePoints, AbilityEnum specialAbility)
            : this(attackPoints, defensePoints)
        {
            this.SpecialAbility = specialAbility;
        }


        public int AttackPoints { get; private set; }

        public int DefensePoints { get; private set; }

        public AbilityEnum SpecialAbility { get; private set; }
    }
}
