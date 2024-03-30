using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using SpeedReflection;
using SpeedReflection.Binary;
using SpeedReflection.Jeson;

//Замерить время до и после вызова функции (для большей точности можно сериализацию сделать в цикле 100-100000 раз)
//  Вывести в консоль полученную строку и разницу времен
// Отправить в чат полученное время с указанием среды разработки и количества итераций
// Замерить время еще раз и вывести в консоль сколько потребовалось времени на вывод текста в консоль
// Провести сериализацию с помощью каких-нибудь стандартных механизмов (например в JSON)
// И тоже посчитать время и прислать результат сравнения
//Написать десериализацию/загрузку данных из строки (ini/csv-файла) в экземпляр любого класса
//Замерить время на десериализацию
//Общий результат прислать в чат с преподавателем в системе в таком виде:

String PathFileBin = @"C:\serialize_spid\serialize.bin";
String PathFileJSON = @"C:\serialize_spid\serialize.json";

BinarySerializerSpid binarySerializer = new(PathFileBin);
BinaryDeserializationSpid binaryDeserialization = new(PathFileBin);
JesonSerializerSpid jesonSerializer = new(PathFileJSON);
JsonDeserializationSpid jsonDeserializationSpid = new(PathFileJSON);

Stopwatch stopWatch = new Stopwatch();


stopWatch.Start();
binarySerializer.Serialize();
stopWatch.Stop();
TimeSpan timeSerializeBinary = stopWatch.Elapsed;

stopWatch.Start();
binaryDeserialization.Deserialization();
stopWatch.Stop();
TimeSpan timeDeserializationBinary = stopWatch.Elapsed;


stopWatch.Start();
jesonSerializer.Serializer();
stopWatch.Stop();
TimeSpan timeSerializerJson = stopWatch.Elapsed;


stopWatch.Start();
jsonDeserializationSpid.Deserialize();
stopWatch.Stop();
TimeSpan timeDeserializationJson = stopWatch.Elapsed;

string timeSpidSerializeBinary = $" Время бинарной сериализации {timeSerializeBinary.Milliseconds} мили секунд \r ";
string timeSpidDerializeBinary = $" Время чтения бинароного файла {timeDeserializationBinary.Milliseconds} мили секунд \r ";
string timeSpidSerializeJson = $" Время JSON cериализации {timeSerializerJson.Milliseconds} мили секунд \r ";
string timeSpidDeserializationJson = $" Время JSON десериализации {timeDeserializationJson.Milliseconds} мили секунд \r ";

Console.WriteLine("Известно что бинарная сериализация менее активно использует рефлексию чем JSON сереализация");
Console.WriteLine("Сравним скорости выполнения бинарной сериализации и сериализации JSON");
Console.WriteLine("для бинарной сериализации и  чтении из файла использовал BinaryWriter и BinaryReader  ");
Console.WriteLine("для JSON сериализации и десериализации использовал JsonSerializer ");
Console.WriteLine("Среда выполнения NET-8, Windows11");
Console.WriteLine(timeSpidSerializeBinary);
Console.WriteLine(timeSpidDerializeBinary );
Console.WriteLine(timeSpidSerializeJson);
Console.WriteLine(timeSpidDeserializationJson);