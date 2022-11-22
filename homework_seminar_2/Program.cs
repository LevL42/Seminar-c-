// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.WriteLine("Введите трёхзначное число:");
int usernum = Convert.ToInt32(Console.ReadLine());
int summ;
if (usernum > 99 && usernum < 1000)
{
    summ = usernum / 10 % (10);
    Console.WriteLine($"Вот ваша цифра {summ}");
}
else
{
    Console.WriteLine("Число не трехзначное");
}*/

/*
int mid(int num1)
{
    int summ = num1;
    if (num1 > 99 && num1 < 1000)
    {
        summ = summ / 10 % (10);             //Подскажите что здесь не так? Как лучше или проще можно было записать.
    }
    else
    {
        Console.Write("что это: ");
    }
    return summ;
}
Console.Write("Введите трехзначное число:");
int usernum = Convert.ToInt32(Console.ReadLine());
int result = mid(usernum);
Console.WriteLine(result);
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

/*
Console.Write("Введите число: ");
int unknown = Convert.ToInt32(Console.ReadLine());

int summ = 0;
while (unknown > 1000)
{
    unknown = unknown / 10;

    Console.WriteLine($"Ищем третье число - {unknown} ");

    summ++;
}
if (unknown > 99 && unknown < 1000)
{
    unknown = unknown % 10;
    Console.WriteLine($"Третье число = {unknown}");
}
else Console.WriteLine($"Это {unknown} не трехзначное число!!!");
*/

int Thirdnumber(int number1)
{
    int three = number1;
    int summ = 0;
    while (three > 1000)
    {
        three = three / 10;

        Console.WriteLine($"Ищем третье число - {three} ");

        summ++;
    }
    if (three < 100)
    {
        Console.WriteLine("Число не трехзначное!!!");
    }

    if (three > 99 && three < 1000)
    {
        three = three % 10;
        Console.WriteLine($"Третье число = {three}");
    }

    return three;
}

Console.Write("Введите число: ");
int unknown = Convert.ToInt32(Console.ReadLine());
int day = Thirdnumber(unknown);

//Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
/*
int Weekend(int num2)
{
    int firstday = num2;
    if (firstday >= 6 && firstday <= 7)
    {
        Console.WriteLine("Выходной ");
    }
    if (firstday < 6 && firstday < 7)
    {
        Console.WriteLine("Рабочий ДЕНЬ!!!");
    }
    return firstday;
}
Console.Write($"Какой сегодня день недели? ");
int day = Convert.ToInt32(Console.ReadLine());
int dayofweek = Weekend(day);
*/