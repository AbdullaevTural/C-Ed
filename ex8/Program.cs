// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] mas = new int[m, n];
// int[,] mas2 = new int[m, n];

// void PrintArray(int[,] ma)
// {
//     for (int i = 0; i < mas.GetLength(0); i++)
//     {
//         for (int j = 0; j < mas.GetLength(1); j++)
//         {
//             Console.Write($"{ma[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine("---------------------------");
// }
// int[,] FillArray(int[,] ma)
// {
//     int[,] mass = ma;
//     Random rnd = new Random();
//     for (int i = 0; i < mas.GetLength(0); i++)
//     {
//         for (int j = 0; j < mas.GetLength(1); j++)
//         {
//             mass[i, j] = rnd.Next(1, 30);
//         }
//     }
//     return mass;

// }
// FillArray(mas);

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// void SortToLower(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// SortToLower(mas);
// PrintArray(mas);

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// void MinSumRow(int[,] array)
// {
//     int minStart = 0;
//     int minSumRow = 0;
//     int sumRow = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         minStart = array[0, i];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sumRow += array[i, j];

//             if (sumRow < minStart)
//             {
//                 minStart = sumRow;
//                 minSumRow = i;
//             }
//             sumRow = 0;
//         }
//     }

//     Console.Write($"{minSumRow + 1} строка");
// }

// MinSumRow(mas);
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.



// FillArray(mas2);
// PrintArray(mas2);
// PrintArray(mas);
// int[,] mas3 = new int[m, n];
// int[,] NewArray(int[,] array1, int[,] array2, int[,] array3)
// {



//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array1.GetLength(1); j++)
//         {

//             array3[i, j] += array1[i, j] * array2[i, j];

//         }
//     }
//     return array3;
// }

// NewArray(mas, mas2, mas3);
// PrintArray(mas3);

// /*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.*/

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int s = Convert.ToInt32(Console.ReadLine());

int[,,] mas = new int[m, n, s];

void PrintArray(int[,,] ma)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            for (int k = 0; k < mas.GetLength(1); k++)
            {
                Console.Write($"{ma[i, j, k]}({i},{j},{k})  ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine("---------------------------");
}
int number = 0;
int[,,] FillArray(int[,,] ma, int number )
{

    Random rnd = new Random();
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {

            for (int k = 0; k < mas.GetLength(2); k++)
            {
                 int ms = rnd.Next(10, 50); 
                if (FindElement(ma, ms)==true) {
                ma[i, j, k] = ms;}
                else {
                    FillArray(mas, number);            
                    }
                Console.WriteLine(FindElement(ma, ms));
            }
        }
    }
    return ma;

}

  bool FindElement(int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                
                if (array[i, j, k] == el) return false;
            }
        }
    }
    return true;
}

FillArray(mas, number);
PrintArray(mas);



//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Console.WriteLine("Введите начальную цифру");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов и строк");
// int lenght = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[lenght, lenght];

// int[,] Fill2DIntArraySpiral(int lenght, int min)

// {


// int i = 0;
// int j = 0;
// int last = 0;
// while (last < (array.GetLength(0) * array.GetLength(1)))
// {
//   array[i, j] = min;
//   min++;
//   last++;
//   if (i <= j + 1 && i + j < array.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= array.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > array.GetLength(1) - 1)
//     j--;
//   else
//     i--;

// }
// return array;
// }
// Fill2DIntArraySpiral(lenght,min);
// void PrintArray(int[,] ma)
// {
//     for (int i = 0; i < ma.GetLength(0); i++)
//     {
//         for (int j = 0; j < ma.GetLength(1); j++)
//         {
            
//              if (ma[i, j] < 10)
//             {
//                 Console.Write("0" + ma[i, j]);
//                 Console.Write(" ");
//             }
//             else Console.Write(ma[i, j] + " ");
               
            
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine("---------------------------");
// }
// PrintArray(array);

