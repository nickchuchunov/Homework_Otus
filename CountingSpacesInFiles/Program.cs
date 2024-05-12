using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;


namespace CountingSpacesInFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Файлы считываются в массив массивов [] [] -  в каждый массив считываются наименование файла и далее строки из файла ");
            Console.WriteLine("далее подсч итывается  ");


            Console.WriteLine("Укажите путь к папке с 3 файлами");
            string treac =  Console.ReadLine();


            

            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            CountingSpacesInFiles сountingSpacesInFiles1 = new CountingSpacesInFiles(treac);
            сountingSpacesInFiles1.ReadingFilesAsync();
            stopWatch.Stop();
            TimeSpan ts1 = stopWatch.Elapsed;

            stopWatch.Start();
            сountingSpacesInFiles1.ReadingFiles();
            сountingSpacesInFiles1.NumberOfSpacesInTwoDimensionalArrayRows();
            stopWatch.Stop();
            TimeSpan ts2 = stopWatch.Elapsed;


            Console.WriteLine($"Время выполнения с парралельным чтением файлов Task-ми {ts1.Milliseconds} Время при последовательном чтении файлов {ts2.Milliseconds}");
            Console.ReadLine();

        }
    }
}
