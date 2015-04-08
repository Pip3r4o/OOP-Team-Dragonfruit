using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialOfFortune.Classes
{
    class InvalidHighscoresDataException : Exception
    {
        public InvalidHighscoresDataException()
        {

        }

        public InvalidHighscoresDataException(string message)
            : base(message)
        {

        }
    }
}
