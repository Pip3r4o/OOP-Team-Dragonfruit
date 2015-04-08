using System;
using System.Globalization;

namespace TrialOfFortune.Classes
{
    public struct Record : ISerializable<Record>
    {
        private const int NUMBER_OF_RECORD_FIELDS = 4;

        public Record(string name, int score, string uid, DateTime dat)
        {
            Name = name;
            Score = score;
            UID = uid;
            Date = dat;
        }

        public string UID;
        public DateTime Date;
        public string Name;
        public int Score;

        public string Serialize()
        {
            return (this.Name + " " + this.Score.ToString() + " " + this.UID + " " + this.Date.ToString("dd.MM.yyyy"));
        }

        public Record Deserialize(string itemObjectSerialized)
        {
            string[] recordFields = itemObjectSerialized.Split(' ');
            if (recordFields.Length != NUMBER_OF_RECORD_FIELDS)
            {
                throw new InvalidHighscoresDataException(String.Format("Record fields number should be {0}", NUMBER_OF_RECORD_FIELDS));
            }
            return (new Record(recordFields[0], Convert.ToInt32(recordFields[1]), recordFields[2], DateTime.ParseExact(recordFields[3], "dd.MM.yyyy", CultureInfo.InvariantCulture)));
        }
    }
}
