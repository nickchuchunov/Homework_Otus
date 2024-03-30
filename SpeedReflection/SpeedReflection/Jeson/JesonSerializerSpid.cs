using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SpeedReflection.Jeson
{
    internal class JesonSerializerSpid
    {
        string PathFile;
        internal JesonSerializerSpid(string pathFile) 
        {
            PathFile = pathFile;
        }

        internal void Serializer() 
        {
         F f = new F();
         string jsonString = JsonSerializer.Serialize<F>(f);
         string[] s = new string[100];
         for (int i= 0; i<100; i++)
            {
                s[i] = jsonString;
            }
            File.WriteAllLines(PathFile, s);

        }
        
    }
}
