using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GauntletMain.Classes
{
    public static class CardLoader
    {
        public static List<HeroCard> LoadHeroCards()
        {
            var heroes = new List<HeroCard>();

            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("..\\..\\Cards\\heroes.cards", FileMode.Open, FileAccess.Read, FileShare.Read);
            heroes = (List<HeroCard>)formatter.Deserialize(stream);

            stream.Close();
            return heroes;
        }

        public static List<WeaponCard> LoadWeaponCards()
        {
            var weapons = new List<WeaponCard>();

            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("..\\..\\Cards\\monsters.cards", FileMode.Open, FileAccess.Read, FileShare.Read);
            weapons = (List<WeaponCard>)formatter.Deserialize(stream);

            stream.Close();
            return weapons;
        }

        public static List<MonsterCard> LoadMonsterCards()
        {
            var monsters = new List<MonsterCard>();

            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("..\\..\\Cards\\monsters.cards", FileMode.Open, FileAccess.Read, FileShare.Read);
            monsters = (List<MonsterCard>)formatter.Deserialize(stream);

            stream.Close();
            return monsters;
        }

    }
}
