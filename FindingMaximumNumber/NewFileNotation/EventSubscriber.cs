using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingMaximumNumber.NewFileNotation
{
    public static class EventSubscriber
    {

        public  static void PrintFileArgs(object sender, FileArgs file) { Console.WriteLine(file.NameFile); }

    }
}
