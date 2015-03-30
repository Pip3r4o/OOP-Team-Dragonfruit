using System.Windows.Forms;

namespace TrialOfFortune.Classes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Highscore
    {
        public struct Record
        {
            public Record(string nam, int scores)
            {
                Name = nam;
                Score = scores;
            }

            public string Name;
            public int Score;
        }

        private Record PlayerScore ;

        public string Name { get; set; }
        public int Position { get; set; }
        public int Score { get; set; }

        public Highscore(string name, int coinss)
        {
            PlayerScore = new Record(name, coinss);
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}", PlayerScore.Name, PlayerScore.Score);
        }


        public void WriteScore(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Append);

            using (StreamWriter sw = new StreamWriter(fs ))
            {
                sw.WriteLine(PlayerScore.Name + " " + PlayerScore.Score.ToString());
            }

        }

        public  List<Record> ReadScoresFromFile(string path)
        {
            List<Record> returnVal = new List<Record>();
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(' ');
                    returnVal.Add( new Record(line[0], Convert.ToInt32(line[1])));
                }
            }
            return returnVal;
        }

        static List<Highscore> SortAndPositionHighscores(List<Highscore> scores)
        {
            scores = scores.OrderByDescending(s => s.Score).ToList();
            int pos = 1;
            scores.ForEach(s => s.Position = pos++);
            return scores.ToList();
        }
    }
}
