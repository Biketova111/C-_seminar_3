/* Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36*/

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);
        
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
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

int GetSum(int number)
{
    int sum = 0;

    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

int number = GetNumber("Введите число больше 0");
int sum = GetSum(number);

Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");