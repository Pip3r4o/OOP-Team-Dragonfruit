using System.Drawing;
using TrialOfFortune.Classes;

namespace TrialOfFortune.Cards
{
    interface ICardFactory
    {
        HeroCard CreateHeroCard(string name, Image artImage, Image miniArtImage, int healthPoints, int actionPoints, EntityStats stats);

        WeaponCard CreateWeaponCard(string name, Image artImage, Image miniArtImage, int additionalDice, EntityStats stats);

        MonsterCard CreateMonsterCard(string name, Image artImage, int damage, EntityStats stats, bool alive, int coinsAwarded);

        ModifierCard CreateModifierCard(string name, Image artImage, ModifierEventEnum modifierEvent);
    }
}
