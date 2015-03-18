namespace GauntletMain.Classes
{
    public class EntityStats
    {
        public EntityStats(int attackPoints, int defensePoints)
        {
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
        }

        public EntityStats(int attackPoints, int defensePoints, Ability specialAbility)
            : this(attackPoints, defensePoints)
        {
            this.SpecialAbility = specialAbility;
        }


        public int AttackPoints { get; set; }

        public int DefensePoints { get; set; }

        public Ability SpecialAbility { get; set; }
    }
}
