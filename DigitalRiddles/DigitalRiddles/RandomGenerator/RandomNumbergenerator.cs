using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DigitalRiddles.RandomGenerator
{
    public class RandomNumbergenerator : IGeneratorRndom
    {
          Random rnd;
        public RandomNumbergenerator()
          {
           rnd = new Random();
          }

        public int RandomGenerator(int value1=0, int value2=100)
        {
          return rnd.Next(value1, value2);
        }
    }
}
