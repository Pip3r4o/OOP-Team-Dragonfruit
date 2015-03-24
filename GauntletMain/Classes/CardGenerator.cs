using System.Collections.Generic;
using System.Drawing;

namespace GauntletMain.Classes
{
    public class CardGenerator
    {
        public const string assetsPathHero = "..\\..\\Assets\\Heroes\\";
        public const string assetsPathWeapon = "..\\..\\Assets\\Weapons\\";
        public const string assetsPathMonster = "..\\..\\Assets\\Monsters\\";
        public const string assetsPathModifier = "..\\..\\Assets\\Modifiers\\";


        public static void CreateHeroCard()
        {
            //Abilities not added to entity stats
            HeroCard rangerCard = new HeroCard("Ranger", Image.FromFile(assetsPathHero + "ranger.jpg"), 1, 2, new EntityStats(2, 14));
            HeroCard druidCard = new HeroCard("Druid", Image.FromFile(assetsPathHero + "druid.jpg"), 1, 2, new EntityStats(1, 16));
            HeroCard minerCard = new HeroCard("Miner", Image.FromFile(assetsPathHero + "miner.jpg"), 2, 2, new EntityStats(1, 13));
            HeroCard necromancerCard = new HeroCard("Necromancer", Image.FromFile(assetsPathHero + "necromancer.jpg"), 1, 3, new EntityStats(2, 14));
            HeroCard berserkerCard = new HeroCard("Berserker", Image.FromFile(assetsPathHero + "berserker.jpg"), 1, 1, new EntityStats(3, 14));
            HeroCard juggernautCard = new HeroCard("Juggernaut", Image.FromFile(assetsPathHero + "juggernaut.jpg"), 1, 2, new EntityStats(0, 17));

            var heroes = new List<HeroCard>
            {
                rangerCard,
                druidCard,
                minerCard,
                necromancerCard,
                berserkerCard,
                juggernautCard
            };
        }

        public static void CreateWeaponCard()
        {
            WeaponCard weapon1 = new WeaponCard("Bloodied Waraxe", Image.FromFile(assetsPathWeapon + "axe.jpg"), 2, new EntityStats(3, 0));
            WeaponCard weapon2 = new WeaponCard("Warlock's Grimoire", Image.FromFile(assetsPathWeapon + "grimoire.jpg"), 3, new EntityStats(0, 0));
            WeaponCard weapon3 = new WeaponCard("Rusty Pickaxe", Image.FromFile(assetsPathWeapon + "pickaxe.jpg"), 2, new EntityStats(2, 1));
            WeaponCard weapon4 = new WeaponCard("Worn-out Wooden Shield", Image.FromFile(assetsPathWeapon + "shield.jpg"), 2, new EntityStats(0, 3));
            WeaponCard weapon5 = new WeaponCard("Nature-imbued Staff", Image.FromFile(assetsPathWeapon + "staff.jpg"), 2, new EntityStats(1, 2));
            WeaponCard weapon6 = new WeaponCard("Yew Longbow", Image.FromFile(assetsPathWeapon + "longbow.jpg"), 2, new EntityStats(2, 1));

            var weapons = new List<WeaponCard>
            {
                weapon1,
                weapon2,
                weapon3,
                weapon4,
                weapon5,
                weapon6
            };
        }

        public static void CreateMonsterCard()
        {
            MonsterCard monster1 = new MonsterCard("Hell Dog", Image.FromFile(assetsPathMonster + "dog.jpg"), 1, new EntityStats(15, 15), true, 1);
            MonsterCard monster2 = new MonsterCard("Lost Bandit", Image.FromFile(assetsPathMonster + "bandit.jpg"), 1, new EntityStats(13, 12), true, 1);
            MonsterCard monster3 = new MonsterCard("Hallucination", Image.FromFile(assetsPathMonster + "hallucination.jpg"), 2, new EntityStats(17, 11), true, 1);
            MonsterCard monster4 = new MonsterCard("Molerat", Image.FromFile(assetsPathMonster + "molerat.jpg"), 2, new EntityStats(16, 15), true, 2);
            MonsterCard monster5 = new MonsterCard("Fallen Adventurer", Image.FromFile(assetsPathMonster + "adventurer.jpg"), 2, new EntityStats(17, 20), true, 3);
            MonsterCard monster6 = new MonsterCard("Animated Statue", Image.FromFile(assetsPathMonster + "statue.jpg"), 1, new EntityStats(15, 19), true, 2);
            MonsterCard monster7 = new MonsterCard("Devourer", Image.FromFile(assetsPathMonster + "devourer.jpg"), 2, new EntityStats(14, 17), true, 2);
            MonsterCard monster8 = new MonsterCard("Moss Giant", Image.FromFile(assetsPathMonster + "mossgiant.jpg"), 3, new EntityStats(19, 21), true, 3);
            MonsterCard monster9 = new MonsterCard("Sewer Rat", Image.FromFile(assetsPathMonster + "rat.jpg"), 1, new EntityStats(13, 9), true, 1);
            MonsterCard monster10 = new MonsterCard("Volatile Goo", Image.FromFile(assetsPathMonster + "goo.jpg"), 1, new EntityStats(15, 16), true, 2);
            MonsterCard monster11 = new MonsterCard("Mutated Bat", Image.FromFile(assetsPathMonster + "bat.jpg"), 2, new EntityStats(14, 13), true, 1);
            MonsterCard monster12 = new MonsterCard("Zombie", Image.FromFile(assetsPathMonster + "zombie.jpg"), 1, new EntityStats(18, 11), true, 2);
            MonsterCard monster13 = new MonsterCard("Troll", Image.FromFile(assetsPathMonster + "troll.jpg"), 2, new EntityStats(21, 17), true, 4);
            MonsterCard monster14 = new MonsterCard("Dusty Mimic Chest", Image.FromFile(assetsPathMonster + "mimic.jpg"), 2, new EntityStats(10, 10), true, 3);
            MonsterCard monster15 = new MonsterCard("Toxic Spider", Image.FromFile(assetsPathMonster + "spider.jpg"), 2, new EntityStats(17, 14), true, 2);



            var monsters = new List<MonsterCard>
            {
                monster1,
                monster2,
                monster3,
                monster4,
                monster5,
                monster6,
                monster7,
                monster8,
                monster9,
                monster10,
                monster11,
                monster12,
                monster13,
                monster14,
                monster15
            };

        }

        public static void CreateModifierCard()
        {
            
        }

    }
}
