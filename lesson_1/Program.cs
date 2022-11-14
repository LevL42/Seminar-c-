// Напишите программу которая получает на вход два числа и проверят является первое квадратом второго
/*
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 / number2 == number2)
{
    Console.WriteLine($"{number1} Является квадратом {number2}");
}
else
{
    Console.WriteLine($"{number1} не является квадратом {number2}");
}
*/

//Напишите программу которая получает число на вход и выводит его значения от -N до N
/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = number * (-1);
while (current <= number)
{
    Console.Write(current + " ");
    current++;
}
*/

//Напишите программу которая принимает на вход трёхзначное число и показывает последнюю цифру этого числа.
/*
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    number = number % 10;
    Console.WriteLine($"Вот ваша цифра {number}");
}
else
{

    Console.WriteLine("Вы ввели не то число");
}
*/