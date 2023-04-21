using System;
using static System.Console;

Write("Введите количество строк массива: ");
int m  = Convert.ToInt32(ReadLine());

Write("Введите колиество сталбцов в массива: ");
int n  = Convert.ToInt32(ReadLine());

int[,] array = new int[m, n];


PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Write(array[i, j] + "\t  ");
        WriteLine();
}

 WriteLine("Введите числа: ");
 int a = Convert.ToInt32(ReadLine());
 int b = Convert.ToInt32(ReadLine());
 if (a > m && b > n)
    WriteLine("такого числа нет: ");
 else
if (a == m && b == n)
    WriteLine("То такще число есть: ");

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}");
        }
        WriteLine();
    }
}
