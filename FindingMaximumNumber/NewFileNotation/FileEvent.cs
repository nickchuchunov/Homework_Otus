using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingMaximumNumber.NewFileNotation
{
    internal class FileEvent
    {
        internal FileEvent() 
        {
            Message = SubscriberFunction;
        }

      internal delegate void EventMesseg(string NewFile);
      internal  event EventMesseg Message;
      void SubscriberFunction(string value) { Console.WriteLine(value); }

   
        internal void FileSearch(string directory) 
       {
            Message = SubscriberFunction;
            if (Directory.Exists(directory))
            {
                var directoryFileEnumerable = Directory.EnumerateFiles(directory);

                foreach (string directoryFile in directoryFileEnumerable) 
                {
                    if (directoryFile != null) { Message(directoryFile); }
                }
            }
            else { Message("Ввден не правильный адрес директории"); Console.WriteLine("Ввден не правильный адрес директории"); throw new ArgumentException("Ввден не правильный адрес директории");  }
       }

    }
}
