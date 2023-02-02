/*Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y). */


using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0 && result < 5)//23
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }

    return result;
}

string GetRange(int quarter)
{
    if (quarter == 1)
    {
        return "x (0; +бесконечности), y  (0; +бесконечности)";
    }
    else if (quarter == 2)
    {
         return "x (0; -бесконечности), y  (0; +бесконечности)";
    }
    else if (quarter == 3)
    {
         return "x (0; -бесконечности), y  (0; -бесконечности)";
    }
    else
    {
         return "x (0; бесконечности), y  (0; -бесконечности)";
    }
}

int namber = GetNumber("Введите четверть");
string range= GetRange(namber);
Console.WriteLine($"диапазон возможных координат точек в этой четверти {range}");

