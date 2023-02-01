// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Создать и распечатать двумерный массив со случайными целыми числами


// // Console.Write("Bведите количество строк массива: ");
// // int rows = int.Parse(Console.ReadLine()!);
// int rows = new Random().Next(2, 7);
// // Console.Write("Введите количество столбцов массива: ");
// // int columns = int.Parse(Console.ReadLine()!);
// int columns = new Random().Next(2, 7);
// Console.WriteLine($"В массиве {rows} и {columns} столбцов:");

// Console.WriteLine();

// int[,] array = GetArray(rows, columns);

// PrintArray(array);
// Console.WriteLine();
// SortArray(array);
// PrintArray(array);


// int[,] GetArray(int m, int n)
// {
//     int[,] result = new int[m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(25);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// // Метод сортировки двумерного массива по убыванию элементов (в строках)

// void SortArray(int[,] MyArray)
// {
//     int[,] result = new int[rows, columns];

//     for (int i = 0; i < MyArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < MyArray.GetLength(1); j++)
//         {
//             for (int t = j + 1; t < MyArray.GetLength(1); t++)
//             {
//                 if (MyArray[i, j] < MyArray[i, j + 1])
//                 {
//                     int temp = array[i, j];
//                     MyArray[i, j] = MyArray[i, j + 1];
//                     MyArray[i, j + 1] = temp;
//                 }
//             }
//         }
//     }
// }

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine();

int rows = new Random().Next(3, 7);
int columns = new Random().Next(3, 7);
Console.WriteLine($"В массиве {rows} строк(и) и {columns} столбца(ов):");

Console.WriteLine();

int[,] array = GetArray(rows, columns);
PrintArray(array);

Console.WriteLine($"Строка с наименьшей суммой №{RowNumber(array)}");
Console.WriteLine();

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(25);
        }
    }
    return result;
}
// --- Метод определения строки с наименьшей суммой ---

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int RowNumber(int[,] array)
{
    int row = 0;
    int minsum = 0;
    for (int i = 1; i < array.GetLength(1); i++)
    {
        minsum += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row;
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
