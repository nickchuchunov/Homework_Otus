using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SpeedReflection
{
    [Serializable]
    public class F
    {

        [JsonInclude]
        public int i1;
        [JsonInclude]
        public int i2;
        [JsonInclude]
        public int i3;
        [JsonInclude]
        public int i4;
        [JsonInclude]
        public int i5;


        public F () 
        { i1 = 1;
          i2 = 2; 
          i3 = 3;
          i4 = 4;
          i5 = 5;
        }

    }
}
