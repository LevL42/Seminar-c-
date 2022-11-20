/*int Method(int number)  // Объявление метода Method.
{
    int one = number % 10;
    int two = number / 10;

    int result;
    if (one > two)
    {
        result = one;
    }
    else result = two;

    return result;  // завершение метода возвращением десятков или единоц.

}
Console.Write("Введите двухзначное число: ");
int thri = Convert.ToInt32(Console.ReadLine());
int res = Method(thri);     // Возов метода с аргументом thri 
Console.WriteLine(res);
*/

//9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*
int Method()
{
    int number = new Random().Next(10, 100);
    Console.WriteLine(number);
    int one = number / 10;
    int two = number % 10;

    int max;

    if (one > two)
    {
        max = one;
    }
    else max = two;

    return max;

}

int maxi = Method();
Console.WriteLine(maxi);
*/

//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

/*
void Cratnost(int num, int a, int b)
{
    if (num % a == 0 && num % b == 0)  // Проверка на кратность
    {
        Console.WriteLine($"Ввше число {num} кратно {a} и {b}");
    }
    else
    {
        Console.WriteLine($"Ваше число {num} не кратно {a} и {b}");
    }

}
// Запрос данных
Console.Write("Введите ваше число1: ");
int user = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ваше число2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ваше число3: ");
int number3 = Convert.ToInt32(Console.ReadLine());
// Вызов метода
Cratnost(user, number2, number3);
*/

//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int random()
{
    int number = new Random().Next(100, 1000);
    Console.WriteLine(number);

    int dec = number / 100;
    int ed = number % 10;
    int summ = dec * 10 + (ed);
    return summ;
}

Console.WriteLine($"Ваше число {random()}");