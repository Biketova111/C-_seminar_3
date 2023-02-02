/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))//23
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

double Distance (int x1, int y1, int x2, int y2)
{
    double dist = Math.Sqrt (Math.Pow((x1-x2),2) +Math.Pow((y1-y2),2));
    return dist; 
}

int x1 = GetNumber ("Введите значение x1");
int y1 = GetNumber ("Введите значение y1");
int x2 = GetNumber ("Введите значение x2");
int y2 = GetNumber ("Введите значение y2");

double result = Distance(x1, y1, x2, y2);
Console.WriteLine($"расстояние между ними в 2D пространстве {result:0.###}");