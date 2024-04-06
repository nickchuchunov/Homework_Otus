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
            foreach (string item in collection) 
            {
                if ((convertToNumber(item) is float) &&(convertToNumber(item)> maxNumber))
                {
                    maxNumber = convertToNumber(item);
                }
            }
            return maxNumber;
        }
    }
}
