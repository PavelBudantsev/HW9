// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Не получается сделать именно эту задачу, но остальные четыре сделал
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int [rows, columns];
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         array[i, j] = new Random().Next(4);
//         Console.Write(array[i, j] +" "); 
//     }
//     Console.WriteLine();                 
// }

// int[] result = new int[columns];
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         result[i] = result[i] + array[i, j];
//     }
// }

// int minIndex = 0;
// for (int i = 0; i < result.Length; i++)
// {
//  if (result[minIndex] > result[i])
//     {
//         minIndex = i;
//     }
// }

// Console.WriteLine("Выводим финализирующую строку");
// for (int i = 0; i < result.Length; i++)
// {
//     Console.Write($"{result[i]} "); 
// }
// Console.WriteLine();
// Console.WriteLine($"Номер строки с минимальной суммой элементов: {minIndex + 1}");


// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// int rows = 2, columns = 2;
// int[,] array1 = new int [rows, columns];
// int[,] array2 = new int [rows, columns];
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         array1[i, j] = new Random().Next(4);
//         array2[i, j] = new Random().Next(9);
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write(array[i, j] +" "); 
//         }
//         Console.WriteLine();                 
//     }
// }

// PrintArray (array1);
// Console.WriteLine();
// PrintArray (array2);
// Console.WriteLine();


// int[,] resultArray = new int[rows, columns];
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         resultArray[i,j] = array1[i,j]+array2[j,i];
//     }
// }

// PrintArray(resultArray);

// Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.
// int firstDimension = 3;
// int secondDimension = 3;
// int thirdDimension = 3;
// int[,,] array = new int[firstDimension,secondDimension,thirdDimension];
// int digital = 99;
// for (int i = 0; i < firstDimension; i++)
// {
//     for (int j = 0; j < secondDimension; j++)
//     {
//         for (int k = 0; k < thirdDimension; k++)
//         {
//             array[i,j,k] = digital;
//             digital --;
//         }
//     }
// }

// for (int i = 0; i < firstDimension; i++)
// {
//     for (int j = 0; j < secondDimension; j++)
//     {
//         for (int k = 0; k < thirdDimension; k++)
//         {
//             Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// int[,] array = new int [4,4];
// int filler = 1;

// for (int i = 0; i < 4; i++)
// {
//     array[0,i] = filler;
//     filler++;
// }

// for (int j = 1; j < 4; j++)
// {
//     array[j,3] = filler;
//     filler++;
// }

// for (int i = 2; i > -1; i--)
// {
//     array[3,i] = filler;
//     filler++;
// }

// for (int j = 2; j > 0; j--)
// {
//     array[j,0] = filler;
//     filler++;
// }

// for (int i = 1; i < 3; i++)
// {
//     array[1,i] = filler;
//     filler++;
// }

// for (int j = 2; j > 0; j--)
// {
//     array[2,j] = filler;
//     filler++;
// }

// for (int i = 0; i < 4; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
// }


