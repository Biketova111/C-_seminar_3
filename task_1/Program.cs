/* Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*/

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result != 0)//23
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

int GetQuarter(int x, int y)
{
    if(x > 0 && y >0)
        return 1;
    else if(x < 0 && y >0)
        return 2;
    else if(x < 0 && y <0)
        return 3;
    else
        return 4;
}

int x = GetNumber("Введите х:");
int y = GetNumber("Введите y:");
int quarter = GetQuarter(x, y);

Console.WriteLine($"точка с координатами ({x},{y}) лежит в {quarter} четверти");

