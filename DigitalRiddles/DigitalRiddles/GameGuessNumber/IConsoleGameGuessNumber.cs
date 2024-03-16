using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRiddles.GameGuessNumber
{
    internal interface IConsoleGameGuessNumber
    {
      internal ConsoleGame UserInterfaceStart();
      internal  bool UserInterface(int UserNumber, int GuessedNumber, int NumberAttempts);
      internal   int EndGameInterface();
      internal  int UserNumberInterface();

    }
}
