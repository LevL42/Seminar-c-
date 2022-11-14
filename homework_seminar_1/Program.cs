// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
/*
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{

    Console.WriteLine($"Число {number1} больше чем {number2}");
}
else
{
    Console.WriteLine($"Число {number2} больше чем {number1}");
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int third = Convert.ToInt32(Console.ReadLine());

int max = 0;
if (first > second) max = first;
if (second > max) max = second;
if (third > max) max = third;
Console.Write($"Самое бльшое число {max}");
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"Ваше число чётное {number}");
}
else
{
    Console.WriteLine("Число не чётное");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int summ = 2;
while (summ <= number)
{
    Console.WriteLine(summ + " ");
    summ += 2;

}


