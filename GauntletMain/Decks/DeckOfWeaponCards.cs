using System.Collections.Generic;
using TrialOfFortune.Classes;
using TrialOfFortune.Cards;

namespace TrialOfFortune.Decks
{
    class DeckOfWeaponCards : Deck<WeaponCard>
    {
        #region Constructors
        public DeckOfWeaponCards()
        {
            WeaponCard weapon1 = new WeaponCard("Bloodied Waraxe", AssetsWeapons.WARAXE, AssetsWeapons.miniWARAXE, 2, new EntityStats(3, 0));
            WeaponCard weapon2 = new WeaponCard("Warlock's Grimoire", AssetsWeapons.GRIMOIRE, AssetsWeapons.miniGRIMOIRE, 3, new EntityStats(0, 0));
            WeaponCard weapon3 = new WeaponCard("Rusty Pickaxe", AssetsWeapons.PICKAXE, AssetsWeapons.miniPICKAXE, 2, new EntityStats(2, 1));
            WeaponCard weapon4 = new WeaponCard("Wooden Shield", AssetsWeapons.SHIELD, AssetsWeapons.miniSHIELD, 2, new EntityStats(0, 3));
            WeaponCard weapon5 = new WeaponCard("Nature Staff", AssetsWeapons.STAFF, AssetsWeapons.miniSTAFF, 2, new EntityStats(1, 2));
            WeaponCard weapon6 = new WeaponCard("Yew Longbow", AssetsWeapons.LONGBOW, AssetsWeapons.miniLONGBOW, 2, new EntityStats(2, 1));

            listOfCards.AddRange(new List<WeaponCard>
            {
                weapon1,
                weapon2,
                weapon3,
                weapon4,
                weapon5,
                weapon6
            });
        }
        #endregion
    }
}
