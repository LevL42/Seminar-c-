// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
int Degree(int a, int b)
{
    int summ = 1;
    for (int c = 0; c < b; c++)
    {
        summ = summ * a;

    }

    return summ;
}
Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int sumnum = Degree(numberA, numberB);
Console.Write(sumnum);
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/*
int Number(int num)
{
    int current = 0;
    int summ = 0;
    while (num > 0)
    {
        summ = num % 10;
        num = num / 10;
        current = current + summ;
    }
    return current;
}

Console.Write("Введите число: ");
int usernum = Convert.ToInt32(Console.ReadLine());

int answer = Number(usernum);
Console.Write($"Сумма чисел = {answer}");
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] First(int size)
{
    int[] number = new int[size];
    for (int i = 0; i < size; i++)
    {
        number[i] = new Random().Next(0, 9);
    }
    return number;
}

void Second(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write(number[i] + " ");
    }
}
Console.Write("Введите количество элементов в массиве: ");
int answer = Convert.ToInt32(Console.ReadLine());

int[] array = First(answer);
Second(array);
