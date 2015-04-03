using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace TrialOfFortune.Classes
{
    public class Highscore
    {


        public Record PlayerScore { get; private set; }

        public string Name { get; set; }
        public int Position { get; set; }
        public int Score { get; set; }

        public Highscore(string name, int coins)
        {
            PlayerScore = new Record(name, coins, Guid.NewGuid().ToString(), DateTime.Today);
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}", PlayerScore.Name, PlayerScore.Score);
        }


        public void WriteScore(string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Append);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(PlayerScore.Name + " " + PlayerScore.Score.ToString() + " " + PlayerScore.UID + " " + PlayerScore.Date.ToString("dd.MM.yyyy"));
                }
            }
            catch (Exception e)
            {
                throw new MyException(e, "There was a problew when saving the result!");
            }
        }

        public List<Record> ReadScoresFromFile(string path)
        {
            List<Record> returnVal = new List<Record>();
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] line = reader.ReadLine().Split(' ');
                        returnVal.Add(new Record(line[0], Convert.ToInt32(line[1]), line[2], DateTime.ParseExact(line[3], "dd.MM.yyyy", CultureInfo.InvariantCulture)));
                    }
                }
            }
            catch (Exception e)
            {
                throw new MyException(e, "There was a problew when reading the result!");
            }
            return returnVal;
        }
    }
}