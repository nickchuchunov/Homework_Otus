using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace SpeedReflection.Binary
{
    internal class BinaryDeserializationSpid
    {
        string PathFile;

        internal BinaryDeserializationSpid(string pathFile) 
        {
            PathFile = pathFile;
        }

        internal void Deserialization() 
        {
            FileStream fileStream1 = new(PathFile, FileMode.OpenOrCreate);
            using (var reader = new BinaryReader(fileStream1, Encoding.UTF8, true))
{
                char[] s = new char[fileStream1.Length];
                byte[] bytes = new byte[fileStream1.Length];
                for (int i = 1; i < fileStream1.Length; i++)
                {
                    bytes[i] = reader.ReadByte();
                }
                for (int i = 2; i < 1500; i++)
                {
                    s[i] = BitConverter.ToChar(bytes, i);
                }
                string _string = new string(s);
                Console.WriteLine(_string);
            }
        }
    }
}
