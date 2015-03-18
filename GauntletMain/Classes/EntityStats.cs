namespace GauntletMain
{
    public class EntityStats
    {
        public EntityStats(int attackPoints, int defensePoints, Ability specialAbility)
        {
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
        }

        public int AttackPoints { get; set; }

        public int DefensePoints { get; set; }
    }
}
