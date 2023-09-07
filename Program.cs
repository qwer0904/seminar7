﻿Console.Write("Введите номер задачи: ");
int a = 0;
try{
a = Convert.ToInt32(Console.ReadLine());
} catch (System.FormatException){
    Console.Write("Это не номер");
    return;
}

switch (a){

    case 47:
    task47();
    break;

    case 50:
    task50();
    break;

    case 52:
    task52();
    break;

    default: 
    Console.WriteLine("Нет такой задачи(");
    break;
}

// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

    void task47()
    {
        Console.Write("Введите m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();

        double[,] array = new double[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                double randomNumber = (random.NextDouble() * 20) - 10;
                
                array[i, j] = Math.Round(randomNumber,1);
            }
        }

        Console.WriteLine("Двумерный массив, заполненный случайными вещественными числами:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine(); 
        }

        Console.ReadLine();
    }

    // Задача 50. Напишите программу, которая на вход принимает 
    // позиции элемента в двумерном массиве, и возвращает 
    // значение этого элемента или же указание, что такого элемента нет.

    void task50(){
        int[,] array = {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4}
        };

        Console.WriteLine("Введите индексы элемента (строка и столбец):");
        Console.Write("Строка: ");
        int rowIndex = Convert.ToInt32(Console.ReadLine());
        Console.Write("Столбец: ");
        int columnIndex = Convert.ToInt32(Console.ReadLine());

        int numRows = array.GetLength(0);
        int numColumns = array.GetLength(1);

        if (rowIndex >= 0 && rowIndex < numRows && columnIndex >= 0 && columnIndex < numColumns)
        {
            int element = array[rowIndex, columnIndex];
            Console.WriteLine("Значение элемента: " + element);
        }
        else
        {
            Console.WriteLine("Элемент с указанными индексами не существует.");
        }

        Console.ReadLine();
    }

    // Задача 52. Задайте двумерный массив из целых чисел. 
    // Найдите среднее арифметическое элементов в каждом столбце.

    void task52(){
        
        int[,] array = {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4}
        };

        int numRows = array.GetLength(0); 
        int numColumns = array.GetLength(1); 

        double[] columnAverages = new double[numColumns];

        for (int columnIndex = 0; columnIndex < numColumns; columnIndex++)
        {
            int columnSum = 0;
            for (int rowIndex = 0; rowIndex < numRows; rowIndex++)
            {
                columnSum += array[rowIndex, columnIndex];
            }

            columnAverages[columnIndex] = Math.Round((double)columnSum / numRows, 1);
        }

        Console.WriteLine("Средние значения по столбцам:");
        for (int columnIndex = 0; columnIndex < numColumns; columnIndex++)
        {
            Console.WriteLine("Столбец " + columnIndex + ": " + columnAverages[columnIndex]);
        }

        Console.ReadLine();
    }