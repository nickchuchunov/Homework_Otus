using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingMaximumNumber.GratestNumber
{
    public static class ExtensionBestIEnumerable 
    {
        public static float GetMax1(this IEnumerable collection, Func<string, float> convertToNumber) 
        {

            float maxNumber = float.MinValue;

            if (collection.GetEnumerator().MoveNext()==true ) 
            {
                foreach (string item in collection)
                {
                    var number = convertToNumber(item);
                    if ((number is float) && (number > maxNumber))
                    {
                        maxNumber = number;
                    }
                }
            }
            else
            {
                maxNumber = 0; throw new Exception("Коллекция пуста");
            }
            return maxNumber;
        }
    }
}
