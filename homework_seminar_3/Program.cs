//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
int Refund(int num)
{
    int summ = num;
    int revers = 0;
    int number = 0;

    while (num > 0)
    {
        number = num % 10;
        revers = revers * 10 + number;
        num = num / 10;

    }

    if (summ == revers)
    {
        Console.Write($"Это палиндром {revers}");
    }
    else Console.WriteLine("Это не палиндром!!!");
    return revers;
}

Console.Write("Введите пятизначное число: ");
int five = Convert.ToInt32(Console.ReadLine());
if (five > 9999 && five < 100000)
{
    Refund(five);
}
else Console.WriteLine("Это не пятизначное число!!!!");
*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Long(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double longABZ = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return longABZ;
}
Console.Write("Введите X кординаты точки А ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y кординаты точки А ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z кординаты точки А ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите X кординаты точки B ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите X кординаты точки B ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите X кординаты точки B ");
int zB = Convert.ToInt32(Console.ReadLine());

double result = Long(xA, yA, zA, xB, yB, zB);
Console.Write($"Ответ {result}");
*/


//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

void Cub(int n)
{
    int summ = 0;
    int count = 1;
    while (count <= n)
    {
        summ = count * 3;
        Console.WriteLine($"Таблица кубов {summ} ");
        count++;
    }
}
Console.Write("Введите число: ");
int numm = Convert.ToInt32(Console.ReadLine());
if (numm == 0)
{
    Console.WriteLine("Число не должно быть = 0");
}
else Cub(numm);

