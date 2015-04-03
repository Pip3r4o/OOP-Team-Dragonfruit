using System;

namespace TrialOfFortune.Classes
{
    public struct Record
    {
        public Record(string nam, int scores, string uid, DateTime dat)
        {
            Name = nam;
            Score = scores;
            UID = uid;
            Date = dat;
        }

        public string UID;
        public DateTime Date;
        public string Name;
        public int Score;
    }
}
