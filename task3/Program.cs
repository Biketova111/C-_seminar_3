/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120*/


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

int GetProduct(int number)
{
    int product = 1;

    for (int i = 1; i <= number; i++)
    {
        product = product*i;
    }
    return product;
}

int number = GetNumber("Введите число больше 0");
int product = GetProduct(number);

Console.WriteLine($"произведение чисел от 1 до {number} = {product}");
