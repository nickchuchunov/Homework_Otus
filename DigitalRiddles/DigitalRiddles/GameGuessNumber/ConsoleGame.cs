using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRiddles.GameGuessNumber
{
    public struct ConsoleGame
    {
        internal int UpperLimitNumber;
        internal int LowerLimitNumber;
        internal int NumberAttempts;

        public ConsoleGame(int upperLimitNumber, int lowerLimitNumber, int numberAttempts)
  
        {
            UpperLimitNumber = upperLimitNumber; LowerLimitNumber = lowerLimitNumber; NumberAttempts = numberAttempts;

        }

     

    }
}
