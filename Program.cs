// ____________________________________Задача 54______________________________________________________
//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Write("Введите количество строк m массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов n массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] randomArray = new int[m,n];

// void mas(int m, int n)
// {
// int i,j;
// Random rand = new Random();
// for (i = 0; i < m; i++)
// {
// for (j = 0; j < n; j++)
// {
// randomArray[i,j] = rand.Next(1,9);
// }
// }
// }

// void printm(int[,] array)
// {
// int i,j;
// for (i = 0; i < array.GetLength(0); i++)
// {
// Console.WriteLine();
// for (j = 0; j < array.GetLength(1); j++)
// {
// Console.Write($"{array[i,j]} ");
// }
// Console.WriteLine();
// }

// }

// mas(m,n);
// Console.WriteLine("\n Полученный масив по Вашим данным массив: ");
// printm(randomArray);


// void uporyadok(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array [i, k] < array[i, k + 1])
//     {
//             int temp = array[i, k + 1];
//                 array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//     }
//             }
//         }
//             }
// }

// uporyadok(randomArray);
// Console.WriteLine("\n Массив полученый согласно условиям задачи:");
// printm(randomArray);


// _______________________________________________Задача 56_________________________________________________________________
//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Write("Введите количество строк m массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов n массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] randomArray = new int[m,n];

// void mas(int m, int n)
// {
// int i,j;
// Random rand = new Random();
//     for (i = 0; i < m; i++)
//         {
//             for (j = 0; j < n; j++)
//                 {
//                     randomArray[i,j] = rand.Next(1,9);
//                 }
//         }
// }

// void printm(int[,] array)
// {
//     int i,j;
//     for (i = 0; i < array.GetLength(0); i++)
//         {
//             Console.WriteLine();
//             for (j = 0; j < array.GetLength(1); j++)
//                 {
//             Console.Write($"{array[i,j]} ");
//                 }
// Console.WriteLine();
//         }
// }
// mas(m,n);
// Console.WriteLine("\n Полученный масив по Вашим данным массив:  ");
// printm(randomArray);

// int SumLine(int[,] array, int i)
// {
// int sum = array[i,0];
// for (int j = 1; j < array.GetLength(1); j++)
//     {
//         sum += array[i,j];
//     }
// return sum;
// }
// int minSum = 1;
// int sum = SumLine(randomArray, 0);
// for (int i = 1; i < randomArray.GetLength(0); i++)
// {
// if (sum > SumLine(randomArray, i))
//     {
//         sum = SumLine(randomArray, i);
//         minSum = i+1;
//     }
// }
// Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");


// ______________________________________Задача 58__________________________________
//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
// int m = InputNumbers("Введите число строк 1-й матрицы: ");
// int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
// int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
// int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

// int[,] firstMartrix = new int[m, n];
// CreateArray(firstMartrix);
// Console.WriteLine($"Первая матрица:");
// WriteArray(firstMartrix);

// int[,] secomdMartrix = new int[n, p];
// CreateArray(secomdMartrix);
// Console.WriteLine($"Вторая матрица:");
// WriteArray(secomdMartrix);

// int[,] resultMatrix = new int[m,p];

// MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine($"Произведение первой и второй матриц:");
// WriteArray(resultMatrix);

// void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secomdMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// __________________________________________________________________Задача 60__________________________________________________________
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// // 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] array3D = new int[2, 2, 2];
// FillArray(array3D);
// PrintIndex(array3D);


// void PrintIndex(int[,,] arr)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }

// void FillArray(int[,,] arr)
// {
//     int count = 10;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 arr[k, i, j] += count;
//                 count += 3;
//             }
//         }
//     }
// }


// _________________________________________Задача 62__________________________________________________________
//  Напишите программу, которая заполнит спирально массив 4 на 4.
// 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.WriteLine("Введите размер  массива");
int size = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(nums);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}