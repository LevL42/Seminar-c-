// Напишите программу, которая принемает на вход число (A) и выдаёит сумму чисел от 1 до А

/*
void Method1(int a)
{
    int summ = 0;
    for (int corent = 1; corent <= a; corent++)
    {
        summ = summ + corent;
    }
    Console.WriteLine($"Сумма элементов от 1 до {a} = {summ}");
}
Console.WriteLine("Введите ваше число: ");
int user = Convert.ToInt32(Console.ReadLine());
Method1(user);
*/
/*
int Num(int a)
{
    int summ = 0;
    for (int current = 1; current <= a; current++)
    {
        summ = summ + current;
    }
    return summ;
}
Console.WriteLine("Введите ваше число: ");
int user = Convert.ToInt32(Console.ReadLine());
int owner = Num(user);
Console.WriteLine($"Сумма элементов от 1 до {user} = {owner}");
*/

//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

/*
int Number(int num)
{
    int current = 1;
    for (current = 1; num >= 10; current++)
    {
        num = num / 10;
    }
    return current;
}

Console.WriteLine("Введите число: ");
int owner = Convert.ToInt32(Console.ReadLine());

int summ_owner;
int user_owner = (-1) * owner;
if (owner > 0)
{
    summ_owner = Number(owner);
}
else
{
    summ_owner = Number(user_owner);
}
Console.WriteLine($"Ввашем числе {owner} количество цифр {summ_owner}");
*/

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N

/*
void Faktorial(int n)
{
    int summ = 1;
    for (int count = 1; count <= n; count++)
    {
        summ *= count;
    }
    Console.WriteLine($"Факториал из {n} = {summ}");
}
Console.WriteLine("Введите число от 1... ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    while (number < 0)
    {
        Console.WriteLine("Введите положительное целое число");
        number = Convert.ToInt32(Console.ReadLine());
    }
}
Faktorial(number);
*/
/*
int[] CreatNewArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.Write("Введите количество элементов массива: ");
int count_of_elem = Convert.ToInt32(Console.ReadLine());
int[] array1 = CreatNewArray(count_of_elem);
ShowArray(array1);
*/


int[] CreatNewArray(int size, int max, int min)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.Write("Введите количество элементов массива: ");
int count_of_elem = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение элементов массива: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минемальное значение элементов массива: ");
int min = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreatNewArray(count_of_elem, max, min);
ShowArray(array1);