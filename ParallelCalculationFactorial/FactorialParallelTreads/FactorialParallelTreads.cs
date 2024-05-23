using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelCalculationFactorial.FactorialParallelTreads
{
    internal class FactorialParallelTreads
    {

       internal ConcurrentDictionary<int, ulong> dictionaryFactorial;
       
        internal FactorialParallelTreads()
        {
            dictionaryFactorial = new ConcurrentDictionary<int, ulong>();
           
        }

        internal void FactorialParallel(int value1, int value2)
        {
            for (int i = value1; i<= value2;i++ ) 
            {
             Thread newThread = new Thread(()=> new Factorial().FactorialAddConcurrentDictionary(i, dictionaryFactorial));
                newThread.Start();
            }
        }

    }
}
