using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SpeedReflection.Jeson
{
    internal class JsonDeserializationSpid
    {
        string PathFile;
        internal JsonDeserializationSpid(string pathFile)
        {
            PathFile = pathFile;
        }

        internal void Deserialize()
        {
            string [] ArrayJeson = File.ReadLines(PathFile).ToArray();

           for (int i=1; i< ArrayJeson.Length; i++)
           { 
              F _f = JsonSerializer.Deserialize<F>(ArrayJeson[i]);
              Console.WriteLine($"i1 ={_f.i1}, i2 ={_f.i2}, i3 ={_f.i3}, i4 ={_f.i4}, i5 ={_f.i5},");
           }
        }
    }
}
