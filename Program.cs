// //Семинар 7:

// // Печать 2-мерного массива
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
// // Создать 2-мерный рандомный(0-9) массив
int[,] CreateRandomArray(int n, int m)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

// // Найти индексы первого минимального элемента 2-мерного массива:

int[] IndexMin(int[,] matrix)
{
    int min = 10;
    int[] index = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min=matrix[i, j];
                index[0] = i;
                index[1] = j;
            }
        }
    }
    return index;
}


// // Задача 53
// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.

// int[,] ReplaceRow(int[,] matrix)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         int temp = matrix[0, j];
//         matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
//         matrix[matrix.GetLength(1) - 1, j] = temp;
//     }
//     return matrix;
// }


// //Задача 55: Задайте двумерный массив. 
// //Напишите программу, которая заменяет строки на столбцы. 
// //В случае, если это невозможно, 
// //программа должна вывести сообщение для пользователя.

// // Решение с заменой в одном массиве:

// int[,] ReplaceRowCol(int[,] matrix)
// {
//     if (matrix.GetLength(0) != matrix.GetLength(1)) Console.WriteLine("Поменять строки и столбцы местами невозможно!");
//     int N =0;
//     int M =0;
//     for (int i = N; i < matrix.GetLength(0); i++)
//     {
//         for (int j = M; j < matrix.GetLength(1); j++)
//         {
//             int temp = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temp;
//         }
//         M++;
//         N++;
//     }
//     return matrix;
// }

// // Решение с переписыванием во второй массив:

// int[,] ReplaceRowCol(int[,] matrix)
// {
//     if (matrix.GetLength(0) != matrix.GetLength(1)) Console.WriteLine("Поменять строки и столбцы местами невозможно!");
//     // int N =0;
//     // int M =0;
//     int[,] result = new int [matrix.GetLength(0), matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             result[j, i] = matrix[i, j];
//         }
//     }
//     return result;
// }


// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива. 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 5 2 6 7 
// Наименьший элемент -1, 
// на выходе получим следующий массив: 
// 9 4 2 
// 2 2 6 
// 3 4 7

// void  DelMinRowCol(int[,] matrix)
// {
//     int[] iMin = IndexMin(matrix);
    
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i != iMin[0] && j != iMin[1]) Console.Write($"{matrix[i, j]}\t");
//         }
//     Console.WriteLine();
//     }
// }


// //Задача 60:Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// //Напишите программу, которая будет построчно выводить массив, 
// //добавляя индексы каждого элемента.


// //Задача 62:Заполните спирально массив 4 на 4.
// // 1  2  3  4
// // 12 13 14 5
// // 11 16 15 6
// // 10 9  8  7


int[,] array = CreateRandomArray(5, 5);
PrintArray(array);

// int[,]resArray =ReplaceRow(array);

// int[,] resArray = ReplaceRowCol(array);

// DelMinRowCol(array);

// int[] res = IndexMin(array);
// Console.WriteLine(res[0] + " " + res[1]);

// PrintArray(resArray);