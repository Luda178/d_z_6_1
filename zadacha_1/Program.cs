using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());



double[,] a = new double[3, 4];

Random random = new Random();

    for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                a[i, j] = new Random().NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
                Write("{0,6:F2}", a[i, j]);
            }
            WriteLine();
        }

        double[,] FillMatrix(int rows, int cols)
        {
            double[,] array = new double[rows, cols];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = Math.Round(rand.Next(-100, 101) * 0.1, 1);
                }
            }
            return array;
        }
       void PrintArray(int[,] inArray)
        {
            for (int i = 0; i < inArray.GetLength(0); i++)
            {
                for (int j = 0; j < inArray.GetLength(1); j++)
                {
                    Write($"{inArray[i, j]}");
                }
            }
        }

