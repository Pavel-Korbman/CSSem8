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
            if(i==0 && j==0) matrix[i, j] = 1;
            else matrix[i, j] = new Random().Next(2, 10);
        }
    }
    return matrix;
}



// // Задача 53
// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.

int[,] ReplaceRow(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(1) - 1, j] = temp;
    }
    return matrix;
}


// //Задача 55: Задайте двумерный массив. 
// //Напишите программу, которая заменяет строки на столбцы. 
// //В случае, если это невозможно, 
// //программа должна вывести сообщение для пользователя.
// // РЕШЕНИЕ НЕ МЕНЯЕТ МАССИВ - НЕ РЕШЕНО!

// int[,] ReplaceRowCol(int[,] matrix)
// {
//     if (matrix.GetLength(0) != matrix.GetLength(1)) Console.WriteLine("Поменять строки и столбцы местами невозможно!");
//     // int[] temp = new int[matrix.GetLength(0)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             temp[j] = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temp[j];
//         }
//     }
//     return matrix;
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

int[,] DelMinRowCol(int[,] matrix)
{
    int min = 0;
    int iMin = 0;
    int jMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min>matrix[i, j])
            {
             min=matrix[i, j];
             iMin = i;
             jMin = j;  
            }
        }
    }
    
    int[,] resMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
           if(i!= iMin || j!= jMin) resMatrix[i, j] = matrix[i, j] ;
        }
    }
    return resMatrix;
}











int[,] array = CreateRandomArray(5, 5);
PrintArray(array);
// int[,]resArray =ReplaceRow(array);
// int[,] resArray = ReplaceRowCol(array);
int[,]resArray =DelMinRowCol(array);
PrintArray(resArray);