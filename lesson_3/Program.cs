//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, в которой находится эта точка
/*
void Funkt(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Ваша точка в первой четверти ");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Ваша точка во второй четверти ");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Ваша точка в третьей четверти ");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Ваша точка в четвертой четверти ");
    }
    else
    {
        Console.WriteLine("Вы вне зоны кродинат ");
    }
}

Console.Write("Введите кординаты X: ");
int kordx = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кординаты Y: ");
int kordy = Convert.ToInt32(Console.ReadLine());

Funkt(kordx, kordy);
*/

//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void Position(int n)
{
    if (n == 1)
    {
        Console.WriteLine("Первая четверть x > 0, y > 0 ");
    }
    else if (n == 2)
    {
        Console.WriteLine("Вторая четверть x < 0, y > 0 ");
    }
    else if (n == 3)
    {
        Console.WriteLine("Третья четверть x < 0, Y < 0 ");
    }
    else Console.WriteLine("Четвертая четверть x > 0, Y < 0 ");
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number <= 4)
{
    Position(number);
}
else Console.WriteLine("Это число не соответсвует четверти ");
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.


double LongLine(int x1, int y1, int x2, int y2)
{
    double lenghAB = Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)), 5);
    return lenghAB;
}
Console.Write("input X coordinat A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("input Y coordinat A: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.Write("input X coordinat B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("input Y coordinat B: ");
int yB = Convert.ToInt32(Console.ReadLine());
double result = LongLine(xA, yA, xB, yB);

Console.WriteLine($"distance AB {result}");


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

/*
void Qurdr(int num)
{
    int current = 1;
    while (current <= num)
    {
        int res = current * current;
        Console.Write($"{res} ");
        current++;
    }
}
Console.Write("input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1)
{
    //Console.WriteLine($"{number}");
    Qurdr(number);
}
else Console.WriteLine("imposible number");
*/