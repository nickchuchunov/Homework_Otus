﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParallelCalculationFactorial.FactorialParallelTreads;

namespace ParallelCalculationFactorial.FactorialParallelPLINQ
{
    internal class FactorialParallelPLINQ
    {

        internal ConcurrentDictionary<int, ulong> dictionaryFactorial;

        Factorial factorial;
        delegate void delegatFactorial(int value, ConcurrentDictionary<int, ulong> dictionary );
       
        internal FactorialParallelPLINQ()
        {   
            dictionaryFactorial = new ConcurrentDictionary<int, ulong>();
            factorial = new Factorial();
        }


      internal void  FactorialForPlinq(int value1, int value2) 
        {
            Parallel.For(value1, value2, (i) => factorial.FactorialAddConcurrentDictionary(i, dictionaryFactorial));
        }
    }
}