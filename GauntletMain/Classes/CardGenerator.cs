using System.Collections.Generic;

namespace GauntletMain.Classes
{
    public class CardGenerator
    {
        public static List<HeroCard> ListOfHeroes = new List<HeroCard>();
        public static List<WeaponCard> ListOfWeapons = new List<WeaponCard>(); 

        public static void CreateHeroCard()
        {
            //Abilities not added to entity stats
            HeroCard rangerCard = new HeroCard("Ranger", AssetsHeroes.RANGER, AssetsHeroes.miniRANGER, 1, 2, new EntityStats(2, 14));
            HeroCard druidCard = new HeroCard("Druid", AssetsHeroes.DRUID, AssetsHeroes.miniDRUID, 1, 2, new EntityStats(1, 16));
            HeroCard minerCard = new HeroCard("Miner", AssetsHeroes.MINER, AssetsHeroes.miniMINER, 2, 2, new EntityStats(1, 13));
            HeroCard necromancerCard = new HeroCard("Necromancer", AssetsHeroes.NECROMANCER, AssetsHeroes.miniNECROMANCER,  1, 3, new EntityStats(2, 14));
            HeroCard berserkerCard = new HeroCard("Berserker", AssetsHeroes.BERSERKER, AssetsHeroes.miniBERSERKER, 1, 1, new EntityStats(3, 14));
            HeroCard juggernautCard = new HeroCard("Juggernaut", AssetsHeroes.JUGGERNAUT, AssetsHeroes.miniJUGGERNAUT, 1, 2, new EntityStats(0, 17));

            ListOfHeroes.Add(rangerCard);
            ListOfHeroes.Add(druidCard);
            ListOfHeroes.Add(minerCard);
            ListOfHeroes.Add(necromancerCard);
            ListOfHeroes.Add(berserkerCard);
            ListOfHeroes.Add(juggernautCard);
        }

        public static void CreateWeaponCard()
        {
            WeaponCard weapon1 = new WeaponCard("Bloodied Waraxe", AssetsWeapons.WARAXE, AssetsWeapons.miniWARAXE, 2, new EntityStats(3, 0));
            WeaponCard weapon2 = new WeaponCard("Warlock's Grimoire", AssetsWeapons.GRIMOIRE, AssetsWeapons.miniGRIMOIRE, 3, new EntityStats(0, 0));
            WeaponCard weapon3 = new WeaponCard("Rusty Pickaxe", AssetsWeapons.PICKAXE, AssetsWeapons.miniPICKAXE, 2, new EntityStats(2, 1));
            WeaponCard weapon4 = new WeaponCard("Wooden Shield", AssetsWeapons.SHIELD, AssetsWeapons.miniSHIELD, 2, new EntityStats(0, 3));
            WeaponCard weapon5 = new WeaponCard("Nature Staff", AssetsWeapons.STAFF, AssetsWeapons.miniSTAFF, 2, new EntityStats(1, 2));
            WeaponCard weapon6 = new WeaponCard("Yew Longbow", AssetsWeapons.LONGBOW, AssetsWeapons.miniLONGBOW, 2, new EntityStats(2, 1));

            ListOfWeapons.Add(weapon1);
            ListOfWeapons.Add(weapon2);
            ListOfWeapons.Add(weapon3);
            ListOfWeapons.Add(weapon4);
            ListOfWeapons.Add(weapon5);
            ListOfWeapons.Add(weapon6);
        }

        public static void CreateMonsterCard()
        {
            MonsterCard monster1 = new MonsterCard("Hell Dog", AssetsMonsters.DOG, 1, new EntityStats(15, 15), true, 1);
            MonsterCard monster2 = new MonsterCard("Lost Bandit", AssetsMonsters.BANDIT, 1, new EntityStats(13, 12), true, 1);
            MonsterCard monster3 = new MonsterCard("Hallucination", AssetsMonsters.HALLUCINATION, 2, new EntityStats(17, 11), true, 1);
            MonsterCard monster4 = new MonsterCard("Molerat", AssetsMonsters.MOLERAT, 2, new EntityStats(16, 15), true, 2);
            MonsterCard monster5 = new MonsterCard("Fallen Adventurer", AssetsMonsters.ADVENTURER, 2, new EntityStats(17, 20), true, 3);
            MonsterCard monster6 = new MonsterCard("Animated Statue", AssetsMonsters.STATUE, 1, new EntityStats(15, 19), true, 2);
            MonsterCard monster7 = new MonsterCard("Devourer", AssetsMonsters.DEVOURER, 2, new EntityStats(14, 17), true, 2);
            MonsterCard monster8 = new MonsterCard("Moss Giant", AssetsMonsters.MOSSGIANT, 3, new EntityStats(19, 21), true, 3);
            MonsterCard monster9 = new MonsterCard("Sewer Rat", AssetsMonsters.RAT, 1, new EntityStats(13, 9), true, 1);
            MonsterCard monster10 = new MonsterCard("Volatile Goo", AssetsMonsters.GOO, 1, new EntityStats(15, 16), true, 2);
            MonsterCard monster11 = new MonsterCard("Mutated Bat", AssetsMonsters.BAT, 2, new EntityStats(14, 13), true, 1);
            MonsterCard monster12 = new MonsterCard("Zombie", AssetsMonsters.ZOMBIE, 1, new EntityStats(18, 11), true, 2);
            MonsterCard monster13 = new MonsterCard("Troll", AssetsMonsters.TROLL, 2, new EntityStats(21, 17), true, 4);
            MonsterCard monster14 = new MonsterCard("Dusty Mimic Chest", AssetsMonsters.MIMIC, 2, new EntityStats(10, 10), true, 3);
            MonsterCard monster15 = new MonsterCard("Toxic Spider", AssetsMonsters.SPIDER, 2, new EntityStats(17, 14), true, 2);



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
        /*
                public static void CreateModifierCard()
                {
                    ModifierCard modifier1 = new ModifierCard("Spring Trap", AssetsModifiers.TRAP, ModifierEventEnum.SpringTrap);
                    ModifierCard modifier2 = new ModifierCard("Healing Spring", AssetsModifiers.HEALINGSPRING, ModifierEventEnum.HealingSpring);
                    ModifierCard modifier3 = new ModifierCard("Tear Satchel", AssetsModifiers.TEAR, ModifierEventEnum.TearSatchel);
                    ModifierCard modifier4 = new ModifierCard("Good Fortune", AssetsModifiers.FORTUNE, ModifierEventEnum.GoodFortune);
                    ModifierCard modifier5 = new ModifierCard("Bear Trap", AssetsModifiers.BEARTRAP, ModifierEventEnum.BarbedWireTrap);

                    var modifiers = new List<ModifierCard>
                    {
                        modifier1,
                        modifier2,
                        modifier3,
                        modifier4,
                        modifier5
                    };
                }
        */
    }
}
