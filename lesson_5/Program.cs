// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
/*
int[] Newarray(int size, int min, int max)
{
    int[] array = new int[size];  //size задаст пользователь.

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1); // max + 1 потому что в макс не входит последнее число, надо 9 а будет 8
    }               // array это переменная с 6 строки. [i] - Это элемент массива.
    return array;
}

void ViewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindsummPos(int[] array)
{
    int sumPos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPos += array[i];
        }
    }
    return sumPos;
}

int FindsummNeg(int[] array)
{
    int sumNeg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNeg += array[i];
        }
    }
    return sumNeg;
}

int size_array = 12;
int min_array = -9;
int max_array = 9;

int[] createdArray = Newarray(size_array, min_array, max_array);
ViewArray(createdArray);

int resaltPos = FindsummPos(createdArray);
Console.WriteLine($"Сумма положительных элементов = {resaltPos}");

int resaltNeg = FindsummNeg(createdArray);
Console.WriteLine($"Сумма отрицательных элементов = {resaltNeg}");
*/

//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21
/*
int[] NewArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ViewaArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] FindMultiPar(int[] arrayCreatad)
{
    int size2;
    if (arrayCreatad.Length % 2 == 0)
    {
        size2 = arrayCreatad.Length / 2;
    }
    else size2 = (arrayCreatad.Length + 1) / 2;

    int[] arrayMulti = new int[size2];

    for (int i = 0; i < arrayCreatad.Length / 2; i++)
    {
        arrayMulti[i] = arrayCreatad[i] * arrayCreatad[arrayCreatad.Length - 1 - i];
    }

    if (arrayCreatad.Length % 2 != 0)
    {
        arrayMulti[size2 - 1] = arrayCreatad[size2 - 1];
    }
    return arrayMulti;
}
Console.WriteLine("Enter the size of the array ");
int array_size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible val if array");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max possible val if array");
int max = Convert.ToInt32(Console.ReadLine());

int[] array1 = NewArray(array_size, min, max);
ViewaArray(array1);
int[] array2 = FindMultiPar(array1);
ViewaArray(array2);
*/

//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива,
//значения которых лежат в отрезке [10,99].


int[] NewArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ViewaArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int Count1099(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Input min possible val if array");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max possible val if array");
int max = Convert.ToInt32(Console.ReadLine());

int size_array = 12;

int[] arrayCreated = NewArray(size_array, min, max);
ViewaArray(arrayCreated);

int resalt = Count1099(arrayCreated);
Console.WriteLine($"Count elements {resalt}");