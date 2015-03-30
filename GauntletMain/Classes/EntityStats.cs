namespace TrialOfFortune.Classes
{
    public class EntityStats
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


        public int AttackPoints { get; set; }

        public int DefensePoints { get; set; }

        public AbilityEnum SpecialAbility { get; set; }
    }
}
