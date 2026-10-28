using System.Runtime.ConstrainedExecution;
using Tyuiu.SobjaninMI.Sprint5.Task1.V26.Lib;
Console.Title = "Спринт #5 | Выполнил: Собянин М. И. | СМАРТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Работа с файлами                                                  *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #26                                                             *");
Console.WriteLine("* Выполнил: Собянин Михаил Игоревич | СМАРТб-26-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана функция F(x) = (2x+6)/(cos(x)+x) - 3 (произвести табулирование)    *");
Console.WriteLine("* f(x) на заданном диапазоне [-5; 5] с шагом 1. Произвести проверку       *");
Console.WriteLine("* деления на ноль. При делении на ноль вернуть значение 0. Результат      *");
Console.WriteLine("* сохранить в текстовый файл OutPutFileTask1.txt и вывести на консоль в   *");
Console.WriteLine("* таблицу. Значения округлить до двух знаков после запятой.               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("* Диапазон: [-5; 5], шаг: 1                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
DataService ds = new DataService();
int startValue = -5;
int endValue = 5;
string path = ds.SaveToFileTextData(startValue, endValue);
string[] value = File.ReadAllLines(path);
Console.WriteLine("+---------+---------+\r\n|    X    |   f(x)  |\r\n+---------+---------+");
for (int i = 0; i < value.Length; i++)
{
    Console.WriteLine($"| {i - 5,7} | {value[i],7} |");
}
Console.WriteLine("+---------+---------+");
Console.ReadKey();