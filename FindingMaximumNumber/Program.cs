﻿using FindingMaximumNumber.GratestNumber;
using FindingMaximumNumber.NewFileNotation;


// Вывод максимального числа из коллекции

//IEnumerable<string> strings = new List<string>() { "1", "2", "3" }; 
//float ConverterStringDouble (string value) 
//{
//    float result= 0;
//    float.TryParse(value, out result);
//    return result;
//}
//Func<string, float > delegats = ConverterStringDouble;
//float value3 = strings.GetMax1(delegats);
//Console.WriteLine(value3);

//Вывод пути к файлом в дериктории

FileEvent fileEvent = new FileEvent();
fileEvent.FileFound  += EventSubscriber.PrintFileArgs;
Console.WriteLine("Укажите путь к директории");
String directoryTreak  = Console.ReadLine();
fileEvent.FileSearchEventFileFound(directoryTreak);




