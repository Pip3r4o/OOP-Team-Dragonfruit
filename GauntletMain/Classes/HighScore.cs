namespace GauntletMain.Classes
{
    ///Vely still works here
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Highscore
    {
        public string Name { get; set; }
        public int Position { get; set; }
        public int Score { get; set; }

        public Highscore(string data)
        {
            var dataArr = data.Split('-');
            this.Name = dataArr[0];
            this.Score = int.Parse(dataArr[1]);
        }

        public override string ToString()
        {
            return String.Format("{0}. {1}: {2}", this.Position, this.Name, this.Score);
        }

        static List<Highscore> ReadScoresFromFile(string path)
        {
            var scores = new List<Highscore>();

            using (StreamReader reader = new StreamReader(path))
            {
                String line;
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    try
                    {
                        scores.Add(new Highscore(line));
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Invalid score at line \"{0}\": {1}", line, ex);
                    }
                }
            }
            return SortAndPositionHighscores(scores);
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
