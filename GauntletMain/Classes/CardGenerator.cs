using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GauntletMain.Classes
{
    public class CardGenerator
    {
        public const string assetsPath = "..\\..\\Assets\\";

        public static void CreateHeroCard()
        {
            //Abilities not added to entity stats
            HeroCard rangerCard = new HeroCard("Ranger", Image.FromFile(assetsPath + "ranger.jpg"), 1, 2, new EntityStats(2, 1));
            HeroCard druidCard = new HeroCard("Druid", Image.FromFile(assetsPath + "druid.jpg"), 1, 2, new EntityStats(1, 2));
            HeroCard minerCard = new HeroCard("Miner", Image.FromFile(assetsPath + "miner.jpg"), 2, 2, new EntityStats(1, 1));
            HeroCard necromancerCard = new HeroCard("Necromancer", Image.FromFile(assetsPath + "necromancer.jpg"), 1, 3, new EntityStats(2, 0));
            HeroCard berserkerCard = new HeroCard("Berserker", Image.FromFile(assetsPath + "berserker.jpg"), 1, 1, new EntityStats(3, 0));
            HeroCard juggernautCard = new HeroCard("Juggernaut", Image.FromFile(assetsPath + "juggernaut.jpg"), 1, 2, new EntityStats(0, 3));

            var heroes = new List<HeroCard>
            {
                rangerCard,
                druidCard,
                minerCard,
                necromancerCard,
                berserkerCard,
                juggernautCard
            };

            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"..\..\Cards\heroes.cards", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            formatter.Serialize(stream, heroes);
            stream.Close();
        }

        public static void CreateMonsterCard()
        {
            MonsterCard monster1 = new MonsterCard("Moss Giant", Image.FromFile(assetsPath + "mossgiant.jpg"), 3, new EntityStats(19, 21), true, 3);
            MonsterCard monster2 = new MonsterCard("Sewer Rat", Image.FromFile(assetsPath + "rat.jpg"), 1, new EntityStats(13, 9), true, 1);
            MonsterCard monster3 = new MonsterCard("Startled Old Hag", Image.FromFile(assetsPath + "hag.jpg"), 1, new EntityStats(16, 15), true, 2);
            MonsterCard monster4 = new MonsterCard("Mutated Bat", Image.FromFile(assetsPath + "bat.jpg"), 2, new EntityStats(17, 13), true, 1);
            MonsterCard monster5 = new MonsterCard("Zombie", Image.FromFile(assetsPath + "zombie.jpg"), 1, new EntityStats(18, 11), true, 2);
            MonsterCard monster6 = new MonsterCard("Dungeon Troll", Image.FromFile(assetsPath + "troll.jpg"), 2, new EntityStats(21, 17), true, 3);


            var monsters = new List<MonsterCard>
            {
                monster1,
                monster2,
                monster3,
                monster4,
                monster5,
                monster6
            };

            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("..\\..\\Cards\\monsters.cards", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            formatter.Serialize(stream, monsters);
            stream.Close();
        }

    }
}
