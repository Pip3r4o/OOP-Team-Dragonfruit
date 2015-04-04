using System.Collections.Generic;
using TrialOfFortune.Classes;
using TrialOfFortune.Cards;
using System.Drawing;

namespace TrialOfFortune.Decks
{
    public class DeckOfWeaponCards : Deck<WeaponCard>
    {
        private const int NUMBER_OF_WEAPON_CARDS = 6;
        private string[] names;
        private Image[] artImages;
        private Image[] miniArtImages;
        private int[] additionalDice;
        private EntityStats[] stats;

        #region Constructors
        public DeckOfWeaponCards()
        {
            names = new string[NUMBER_OF_WEAPON_CARDS]
            {
                "Bloodied Waraxe",
                "Warlock's Grimoire",
                "Rusty Pickaxe",
                "Wooden Shield",
                "Nature Staff",
                "Yew Longbow"
            };
            artImages = new Image[NUMBER_OF_WEAPON_CARDS]
            {
                AssetsWeapons.WARAXE,
                AssetsWeapons.GRIMOIRE,
                AssetsWeapons.PICKAXE,
                AssetsWeapons.SHIELD,
                AssetsWeapons.STAFF,
                AssetsWeapons.LONGBOW
            };
            miniArtImages = new Image[NUMBER_OF_WEAPON_CARDS]
            {
                AssetsWeapons.miniWARAXE,
                AssetsWeapons.miniGRIMOIRE,
                AssetsWeapons.miniPICKAXE,
                AssetsWeapons.miniSHIELD,
                AssetsWeapons.miniSTAFF,
                AssetsWeapons.miniLONGBOW
            };
            additionalDice = new int[NUMBER_OF_WEAPON_CARDS] { 2, 3, 2, 2, 2, 2 };
            stats = new EntityStats[NUMBER_OF_WEAPON_CARDS]
            {
                new EntityStats(3, 0),
                new EntityStats(0, 0),
                new EntityStats(2, 1),
                new EntityStats(0, 3),
                new EntityStats(1, 2),
                new EntityStats(2, 1)
            };

            var weaponCards = new List<WeaponCard>();
            CardFactory cardFactory = new CardFactory();
            for (int i = 0; i < NUMBER_OF_WEAPON_CARDS; i++)
            {
                weaponCards.Add(cardFactory.CreateWeaponCard(names[i], artImages[i], miniArtImages[i], additionalDice[i], stats[i]));
            }

            listOfCards.AddRange(weaponCards);
        }
        #endregion
    }
}
