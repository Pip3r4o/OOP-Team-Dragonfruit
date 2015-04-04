using System.Drawing;
using TrialOfFortune.Classes;

namespace TrialOfFortune.Cards
{
    public class CardFactory : ICardFactory
    {
        public HeroCard CreateHeroCard(string name, Image artImage, Image miniArtImage, int healthPoints, int actionPoints, EntityStats stats)
        {
            return new HeroCard(name, artImage, miniArtImage, healthPoints, actionPoints, stats);
        }

        public WeaponCard CreateWeaponCard(string name, Image artImage, Image miniArtImage, int additionalDice, EntityStats stats)
        {
            return new WeaponCard(name, artImage, miniArtImage, additionalDice, stats);
        }

        public MonsterCard CreateMonsterCard(string name, Image artImage, int damage, EntityStats stats, bool isAlive, int coinsAwarded)
        {
            return new MonsterCard(name, artImage, damage, stats, isAlive, coinsAwarded);
        }

        public ModifierCard CreateModifierCard(string name, Image artImage, ModifierEventEnum modifierEvent)
        {
            return new ModifierCard(name, artImage, modifierEvent);
        }
    }
}
