using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using static System.Net.WebRequestMethods;

namespace CountingSpacesInFiles
{
    internal class CountingSpacesInFiles
    {

        public string[][] arrey { get; set; }
        internal string pathFolder { get; set; }


        internal CountingSpacesInFiles(string PathFolder)
        {
             arrey = new string[NumberFilesFolder()][];

            //DirectoryInfo di = new DirectoryInfo(PathFolder);
            //FileInfo[] arreyFile = di.GetFiles("*", SearchOption.TopDirectoryOnly);
            //
            //for (int i=0; arrey.Length>0; i++ )
            //{
            //    string[] areyFileText = File.ReadAllLines(arreyFile[i].FullName);
            //    for (int j = 0; areyFileText.Length > 0; j++) 
            //    {
            //        arrey[i][j] = " ";
            //    }
            //    
            //}


             pathFolder = PathFolder;
        }

        // считаем количество файлов в папке
      internal  int NumberFilesFolder()
        {
            int value = 0;
            if (Directory.Exists(pathFolder))
            {
                DirectoryInfo di = new DirectoryInfo(pathFolder);
                FileInfo[] arreyFile = di.GetFiles("*", SearchOption.TopDirectoryOnly);
                value = arreyFile.Length;
            }

            else
            {
                new ArgumentException("указан не существующий путь к папке") { };
            }

            return value;
        }


        // записываем строки в массив [i] [j] где [i][0] = имя файла , [i][j>0] строки из файла
       internal void ReadingFiles()
        {
          string [] []  arrey1 = new string[NumberFilesFolder()][];


            if (Directory.Exists(pathFolder))
            {
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
            }
            arrey = arrey1;
        }


      internal  void ReadingFileWritingArray(string[][] arrey, int arrayNumber, string patch )
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


       internal void  ReadingFilesAsync()
        {

            string[][] arrey1 = new string[NumberFilesFolder()][];

            if (Directory.Exists(pathFolder))
            {
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
        }





            // считаем количество пробелов в массиве 
          internal void NumberOfSpacesInTwoDimensionalArrayRows()
            {
                Dictionary<string, int> dictionary = new Dictionary<string, int>();
                char[] utf8 = Encoding.UTF8.GetChars(new byte[Convert.ToByte(' ')]);
                char[] utf32 = Encoding.UTF32.GetChars(new byte[Convert.ToByte(' ')]);
                char[] utf7 = Encoding.UTF7.GetChars(new byte[Convert.ToByte(' ')]);
                char[] Asc2 = Encoding.ASCII.GetChars(new byte[Convert.ToByte(' ')]);

                for (int i = 0; arrey.Length > i; i++)
                {
                    int numberOfSpaces = 0;

                    for (int j = 0; arrey[i].Length > j; j++)
                    {
                        foreach (char t in arrey[i][j].ToCharArray())
                        {
                            if (t == ' ' || t == utf8[0] || t == utf32[0] || t == utf7[0] || t == Asc2[0])
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
