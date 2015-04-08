using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace TrialOfFortune.Classes
{
    public class Highscore : IHighscore
    {


        public Record playerScore { get; private set; }

        public string Name { get; set; }
        public int Position { get; set; }
        public int Score { get; set; }

        public Highscore(string name, int coins)
        {
            playerScore = new Record(name, coins, Guid.NewGuid().ToString(), DateTime.Today);
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}", playerScore.Name, playerScore.Score);
        }


        public void WriteScoresToFile(string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Append);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(playerScore.Serialize());
                }
            }
            catch (Exception e)
            {
                throw new HighscoresFileAccessConflictException(e, "There was a problem when saving the result!");
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
                        string recordLine = reader.ReadLine();
                        returnVal.Add((new Record()).Deserialize(recordLine));
                    }
                }
            }
            catch (Exception e)
            {
                throw new HighscoresFileAccessConflictException(e, "There was a problem when reading the result!");
            }
            return returnVal;
        }
    }
}