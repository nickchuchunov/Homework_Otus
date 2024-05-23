using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingMaximumNumber.NewFileNotation
{
    internal class FileEvent
    {
      
        public event EventHandler<FileArgs> FileFound;

        internal void FileSearchEventFileFound(string directory) 
       {
            
            if (Directory.Exists(directory))
            {
                var directoryFileEnumerable = Directory.EnumerateFiles(directory);
                foreach (string directoryFile in directoryFileEnumerable) 
                {
                    if (directoryFile != null|| FileFound!=null) { FileArgs _file = new() { NameFile = directoryFile };  FileFound(this, _file); }
                }
            }
            else { Console.WriteLine("Ввден не правильный адрес директории или нет подписчиков на FileFound "); throw new ArgumentException("Ввден не правильный адрес директории");  }
       }

    }
}
