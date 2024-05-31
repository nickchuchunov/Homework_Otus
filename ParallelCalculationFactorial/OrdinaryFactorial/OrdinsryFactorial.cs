using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ParallelCalculationFactorial.OrdinaryFactorial
{
    internal class OrdinsryFactorial
    {

       internal Dictionary<int, BigInteger> Factorial(int value1, int value2 )
        {
            Dictionary<int, BigInteger> factorialDictionary = new Dictionary<int, BigInteger>();

            for (int i = value1; i< value2; i++) 
            {
                BigInteger FactorialNumber = 1;
                for (int j = 1; j < i; j++)
                {
                      FactorialNumber = FactorialNumber *(BigInteger)j;
                }
                
                factorialDictionary.Add(i, FactorialNumber);

            }
            return factorialDictionary;

        }
    }
}
