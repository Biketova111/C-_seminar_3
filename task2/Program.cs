/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/


int GetNumber(string message)
{
    int result;
    while(true)
    {
        Console.WriteLine(message);
        
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или не корректное число.");
        }
    }

    return result;
}

int GetNumberOfDigits (int number)
{
    if (number > 0)
    {
       string numberStr = number.ToString();
        int length = numberStr.Length;
        return length; 
    }
    else
    {
        string numberStr = number.ToString();
        int length = numberStr.Length;
        return length-1; 
    }
    
}

int number = GetNumber("Введите число: ");
int numberOfDigits = GetNumberOfDigits(number);
Console.WriteLine ($"количество цифр в числе = {numberOfDigits}");