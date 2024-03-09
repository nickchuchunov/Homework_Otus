using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRiddles.GameGuessNumber
{
    public class UserInterfaceGameGuessNumber : IUserInterfaceGameGuessNumber
    {

        public UserInterfaceGameGuessNumber() { }

      public  (int UpperLimitNumber, int LowerLimitNumber, int NumberAttempts) UserInterfaceStart()
        {
            Console.WriteLine("Введите число - нижнюю границу диапазона");

            int UpperLimitNumber;

            bool BoolUpperLimitNumber = int.TryParse(Console.ReadLine(), out UpperLimitNumber);

            if (BoolUpperLimitNumber == false) { Console.WriteLine("Вы ввели не корректные данные - повторите попытку"); UserInterfaceStart();  }

            Console.WriteLine("Введите чиcло - верхнюю границу диапазона");

            int LowerLimitNumber;

            bool BoolLowerLimitNumber = int.TryParse(Console.ReadLine(), out LowerLimitNumber); 
            if (BoolLowerLimitNumber == false) { Console.WriteLine("Вы ввели не корректные данные - повторите попытку"); UserInterfaceStart(); }

            Console.WriteLine("Введите чиcло число попыток отгадывания");

            int NumberAttempts;

            bool BoolNumberAttempts = int.TryParse(Console.ReadLine(), out NumberAttempts);

            if (BoolNumberAttempts == false) { Console.WriteLine("Вы ввели не корректные данные - повторите попытку"); UserInterfaceStart(); }

            return (UpperLimitNumber, LowerLimitNumber, NumberAttempts);


        }



       public bool UserInterface (int UserNumber, int GuessedNumber, int NumberAttempts ) 
        {
           bool status = false;

            if (GuessedNumber == UserNumber) { Console.WriteLine($"Вы отгадали число, правильное число {GuessedNumber} "); status = true;  }
            if (GuessedNumber > UserNumber)  { Console.WriteLine($"Вы указали число меньше загаданного, осталось попыток {NumberAttempts}"); }
            if (GuessedNumber < UserNumber) { Console.WriteLine($"Вы указали больше заданного, осталось попыток {NumberAttempts}");  }

            return status;


        }


        public int UserNumberInterface()
        {
            Console.WriteLine("введите новое число для отгадывания");

           int UsetNumber = 0;

            bool UsetNumberBool = int.TryParse(Console.ReadLine(), out UsetNumber);

            if (UsetNumberBool == false) { Console.WriteLine("Вы ввели не коорректные данные повторите ввод"); UserNumberInterface(); }

            return UsetNumber;  

        
        } 


        public int EndGameInterface() 
        {
            Console.WriteLine("Игра завершена для продолжения игры введите 1 для выхода из меню введите 2");

            int value = 0;

            bool number = int.TryParse( Console.ReadLine(), out value);
        
          if (number == false) { Console.WriteLine("Вы ввели не корректные данные повторите ввод"); EndGameInterface(); }

          return value;

        }



    }
}
