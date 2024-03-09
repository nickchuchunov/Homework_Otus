using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRiddles.GameGuessNumber
{
    public interface IUserInterfaceGameGuessNumber
    {
      public  (int UpperLimitNumber, int LowerLimitNumber, int NumberAttempts) UserInterfaceStart();

      public  bool UserInterface(int UserNumber, int GuessedNumber, int NumberAttempts);

     public   int EndGameInterface();
      public  int UserNumberInterface();

    }
}
