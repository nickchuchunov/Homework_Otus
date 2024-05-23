using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelCalculationFactorial.OrdinaryFactorial
{
    internal class OrdinsryFactorial
    {

       internal Dictionary<int, ulong> Factorial(int value1, int value2 )
        {
            Dictionary<int, ulong> factorialDictionary = new Dictionary<int, ulong>();

            

            for (int i = value1; i< value2; i++) 
            {
                ulong FactorialNumber = 1;
                for (int j = 1; j < i; j++)
                {
                      FactorialNumber = FactorialNumber *(ulong)j;
                }
                
                factorialDictionary.Add(i, FactorialNumber);

            }
            return factorialDictionary;

        }
    }
}
