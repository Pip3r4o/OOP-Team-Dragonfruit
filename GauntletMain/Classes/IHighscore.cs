using System;
using System.Collections.Generic;

namespace TrialOfFortune.Classes
{
    interface IHighscore
    {
        string Name { get; set; }
        Record playerScore { get; }
        int Score { get; set; }
        string ToString();

        List<Record> ReadScoresFromFile(string path);
        void WriteScoresToFile(string path);
    }
}
