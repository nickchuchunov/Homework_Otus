using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CountingSpacesInFiles
{
    internal class CountingSpacesInFiles
    {

        public string[][] arrey { get; set; }
        internal string pathFolder { get; set; }

        internal CountingSpacesInFiles(string PathFolder)
        {
            if (Directory.Exists(PathFolder))
            { pathFolder = PathFolder; arrey = new string[NumberFilesFolder()][]; }
            else 
            {new ArgumentException("указан не существующий путь к папке");}
        }

        // считаем количество файлов в папке
        internal int NumberFilesFolder()
        {
            int value = 0;
                DirectoryInfo di = new DirectoryInfo(pathFolder);
                FileInfo[] arreyFile = di.GetFiles("*", SearchOption.TopDirectoryOnly);
                value = arreyFile.Length;
            return value;
        }

        // записываем строки в массив [i] [j] где [i][0] = имя файла , [i][j>0] строки из файла
        internal void ReadingFiles()
        {
                string[][] arrey1 = new string[NumberFilesFolder()][];
                DirectoryInfo di = new DirectoryInfo(pathFolder);
                FileInfo[] arreyFile = di.GetFiles("*", SearchOption.TopDirectoryOnly);

                for (int i = 0; arreyFile.Length > i; i++)
                {
                    string[] areyFileText = File.ReadAllLines(arreyFile[i].FullName);
                    string[] areyFileTextFilleName = new string[areyFileText.Length + 1];
                    areyFileTextFilleName[0] = arreyFile[i].Name;

                    for (int j = 0; areyFileText.Length > j; j++)
                    {
                        areyFileTextFilleName[j + 1] = areyFileText[j];
                    }

                    arrey1[i] = areyFileTextFilleName;
                }
            
            arrey = arrey1;
        }

        //вспомогательная функция для - ReadingFilesAsync записывает наименование и строки файла в указанную строку указанного массива массивов )
        internal void ReadingFileWritingArray(string[][] arrey, int arrayNumber, string patch)
        {
            string[] areyFileText = File.ReadAllLines(patch); //массив строк файла
            string[] areyFileTextFilleName = new string[areyFileText.Length + 1]; // создаем массив длиной масива строк файла + наименование файла 
            DirectoryInfo di = new DirectoryInfo(pathFolder); // 
            FileInfo[] arreyFile = di.GetFiles("*", SearchOption.TopDirectoryOnly); // получаем массив FileInfo
            areyFileTextFilleName[0] = arreyFile[arrayNumber].Name; // добавляем номер файла в массив

            for (int f = 0; f < areyFileText.Length; f++)
            {
                areyFileTextFilleName[f + 1] = areyFileText[f]; // добавляем в массив строки
            }
            arrey[arrayNumber] = areyFileTextFilleName; // добавляем массив (с имененм файла и строками) в массив массивов (с файлами хранящихся в папке)
        }

        // записываем парралельно с помощью Task строки в массив [i] [j] где [i][0] = имя файла , [i][j>0] строки из файла 
        internal void ReadingFilesAsync()
        {
                string[][] arrey1 = new string[NumberFilesFolder()][];
                DirectoryInfo di = new DirectoryInfo(pathFolder);
                FileInfo[] arreyFile = di.GetFiles("*", SearchOption.TopDirectoryOnly);

                for (int i = 0; i < arreyFile.Length; i++)
                {
                    arrey1[i] = new string[File.ReadAllLines(arreyFile[i].FullName).Length + 1];
                    arrey1[i][0] = arreyFile[i].Name;
                }

                Task t1 = Task.Run(() => ReadingFileWritingArray(arrey1, 0, arreyFile[0].FullName));
                Task t2 = Task.Run(() => ReadingFileWritingArray(arrey1, 1, arreyFile[1].FullName));
                Task t3 = Task.Run(() => ReadingFileWritingArray(arrey1, 2, arreyFile[2].FullName));
                t1.Wait();
                t2.Wait();
                t3.Wait();
                arrey = arrey1;
                NumberOfSpacesInTwoDimensionalArrayRows();
                Console.WriteLine("все задачи ваыполненны");
                Console.ReadLine();
        }

        // считаем количество пробелов в массиве 
        internal void NumberOfSpacesInTwoDimensionalArrayRows()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 0; arrey.Length > i; i++)
            {
                int numberOfSpaces = 0;
                for (int j = 0; arrey[i].Length > j; j++)
                {
                    foreach (char t in arrey[i][j].ToCharArray())
                    {
                        if (Char.IsWhiteSpace(' '))
                        {
                            numberOfSpaces++;
                        }
                    }
                }

                dictionary.Add(arrey[i][0], numberOfSpaces);
            }
            foreach (var t in dictionary)
            {
                Console.WriteLine($"в файле {t.Key} пробелов {t.Value}");
            }
            Console.ReadLine();
        }
    }
}
