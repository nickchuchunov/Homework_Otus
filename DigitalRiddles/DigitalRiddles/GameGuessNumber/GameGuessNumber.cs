using DigitalRiddles.RandomGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace DigitalRiddles.GameGuessNumber
{
    internal class GameGuessNumber : IGuessNumber
    {
       IGeneratorRndom rndom;
       IConsoleGameGuessNumber consoleGameGuessNumber;
       internal int UpperLimitNumber;
       internal int LowerLimitNumber;
       internal int NumberAttempts;

      internal GameGuessNumber(IGeneratorRndom _rndom, IConsoleGameGuessNumber _consoleGameGuessNumber) // IServiceProvider service
        {
           rndom = _rndom;
           consoleGameGuessNumber = _consoleGameGuessNumber;
          
        }

           public void StartGamesNumber()
        {
            ConsoleGame _consoleGame = consoleGameGuessNumber.UserInterfaceStart();
            UpperLimitNumber = _consoleGame.UpperLimitNumber;
            LowerLimitNumber = _consoleGame.LowerLimitNumber;
            NumberAttempts = _consoleGame.NumberAttempts;
            Console.WriteLine("Привет");
            int number = rndom.RandomGenerator(UpperLimitNumber, LowerLimitNumber);
            int UserNumber = 0;
            bool status = false;
            while (number!= UserNumber& _consoleGame.NumberAttempts > 0& status==false)
            {
                UserNumber = consoleGameGuessNumber.UserNumberInterface();
                NumberAttempts--;
                status = consoleGameGuessNumber.UserInterface(UserNumber, number, NumberAttempts);
            }
            int StartStopGame = consoleGameGuessNumber.EndGameInterface();
            if (StartStopGame ==1) { StartGamesNumber();  } 
        }
    }
}
