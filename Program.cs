/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 7 -2 -85
1 -3 8 -9
8 7 -7 9*/

/*Console.WriteLine("Количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
Random(array);
Print(array);

void Random(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 99);
        }
    }
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}*/

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
i = 4, j = 2 -> такого числа в массиве нет
i = 1, j = 2 -> 2*/

/*int[,] array = new int[3, 5];
Random(array);
Print(array);
Console.WriteLine("Строка: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Столбец: ");
int m = int.Parse(Console.ReadLine());
if (n > array.GetLength(0) || m > array.GetLength(1))
{
    Console.WriteLine("Нет такого числа.");
}
else
{
    Console.WriteLine("Значение " + n + " строки и " + m + " столбца: " + array[n-1,m-1]);
}

void Random(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 99);
        }
    }
}
void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}*/

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("Количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
Random(array);
Print(array);
Console.WriteLine();
Arifmethic(array);

void Random(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 99);
        }
    }
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

void Arifmethic(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
{
    double a = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        a = (a + array[i, j]);
    }
    a = a / m;
    Console.WriteLine("Среднее арифметическое по " + j + " столбцу : " + a + "; ");
}

}