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
    public class GuessNumber : IGuessNumber
    {
        int UpperLimitNumber;
        int LowerLimitNumber;
        int NumberAttempts;



        IGeneratorRndom rndom;
        IUserInterfaceGameGuessNumber userInterfaceGameGuessNumber;

      public GuessNumber(IServiceProvider service)
        {
           rndom = service.GetService<IGeneratorRndom>();
           userInterfaceGameGuessNumber = service.GetService<IUserInterfaceGameGuessNumber>();

            StartGamesNumber();
        }


            public void StartGamesNumber()
        {

            Console.WriteLine("Привет");

            (UpperLimitNumber, LowerLimitNumber, NumberAttempts) = userInterfaceGameGuessNumber.UserInterfaceStart();

            int number = rndom.RandomGenerator(UpperLimitNumber, LowerLimitNumber);

            int UserNumber = 100000000;

            bool status = false;

            

            while (number!= UserNumber& NumberAttempts>0& status==false)
            {
                UserNumber = userInterfaceGameGuessNumber.UserNumberInterface();

                NumberAttempts--;

                status = userInterfaceGameGuessNumber.UserInterface(UserNumber, number, NumberAttempts);

            }

            int StartStopGame = userInterfaceGameGuessNumber.EndGameInterface();

            if (StartStopGame ==1) { StartGamesNumber();  } 


        }



    }
}
