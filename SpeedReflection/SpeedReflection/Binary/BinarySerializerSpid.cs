using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedReflection.Binary
{
    internal class BinarySerializerSpid
    {
        string PathFile;
        internal BinarySerializerSpid(string pathFile) 
        {
            PathFile = pathFile;
        }

        internal void Serialize () 
        {
            F f = new F();
            FileStream fileStream = new(PathFile, FileMode.OpenOrCreate);
            using (var writer = new BinaryWriter(fileStream, Encoding.UTF8, false))
            {
                for (int i = 0; i < 100; i++)
                {
                    writer.Write(f.i1);
                    writer.Write(f.i2);
                    writer.Write(f.i3);
                    writer.Write(f.i4);
                    writer.Write(f.i5);

                }
            }

            fileStream.Close();
        }
    }
}
