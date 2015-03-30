using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrialOfFortune.Classes;
using WMPLib;
using System.Media;

namespace TrialOfFortune
{
    public class StaticResources
    {
        public static WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        public static SoundPlayer sp = new SoundPlayer();

        public enum FightPhase
        {
            NA,
            Fight,
            Defend
        };

        public static FightPhase CurrentFightPhase = FightPhase.NA;


    }
}
