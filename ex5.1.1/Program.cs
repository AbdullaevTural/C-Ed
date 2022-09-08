// //Задача 34:
// Console.WriteLine("Введите длину массива");
// bool isNumber = int.TryParse(Console.ReadLine(), out int length);
// if (!isNumber || length <= 0)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }


// int[] FillArray(int length)
// {
//     int[] array = new int[length];
//     Random random = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = random.Next(100, 1000);
//     }
//     return array;
// }
// int[] array = FillArray(length);


// int sum = 0;

// int Even(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             sum = ++sum;
//         }
//     }
//     return sum;
// }


// void PrintArray(int[] array, int m)
// {
//     if (array.Length == 0)
//     {
//         Console.WriteLine("Что-то пошло не так");
//         return;
//     }
//     Console.Write("[");

//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]},");
//     }

//     Console.Write(array[array.Length - 1]);
//     Console.Write("]");
//     Console.Write(" -> " + m);
// }

// Even(array);
// PrintArray(array, sum);
// FillArray(length);

// //Задача 36: 
// Console.WriteLine("Введите длину массива");
// bool isNumber = int.TryParse(Console.ReadLine(), out int length);
// if (!isNumber || length <= 0)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }


// int[] FillArray(int length)
// {
//     int[] array = new int[length];
//     Random random = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = random.Next(-100, 100);
//     }
//     return array;
// }
// int[] array = FillArray(length);


// int sum = 0;

// int Sum(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             sum = array[i] + sum;
//         }
//     }
//     return sum;
// }


// void PrintArray(int[] array, int m)
// {
//     if (array.Length == 0)
//     {
//         Console.WriteLine("Что-то пошло не так");
//         return;
//     }
//     Console.Write("[");

//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]},");
//     }

//     Console.Write(array[array.Length - 1]);
//     Console.Write("]");
//     Console.Write(" -> " + m);
// }

// Sum(array);
// PrintArray(array, sum);
// FillArray(length);

//Задача 38:

// Console.WriteLine("Введите длину массива");
// bool isNumber = int.TryParse(Console.ReadLine(), out int length);
// if (!isNumber || length <= 0)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }


// int[] FillArray(int length)
// {
//     int[] array = new int[length];
//     Random random = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = random.Next(-100, 100);
//     }
//     return array;
// }

// int[] array = FillArray(length);
// int max = array[0];
// int min = array[0];

// int Max(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//             max = array[i];
//         }
//     }
//     return max;
// }

// int Min(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }
//     return min;
// }


// int Difference(int min, int max)
// {
//     int difference = 0;
//     if (max < 0 && min < 0)
//     {
//     difference = max - min;
//     return difference;
//     }
//     if (min < 0)
//     {
//     difference = max + min;
//     return difference;
//     }
//     {
//     difference = max - min;
//     return difference; 
//     }
    
     
// }

// void PrintArray(int[] array, int min, int max,  int difference)
// {
//     if (array.Length == 0)
//     {
//         Console.WriteLine("Что-то пошло не так");
//         return;
//     }
//     Console.Write("[");

//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]},");
//     }

//     Console.Write(array[array.Length - 1]);
//     Console.Write("]");
//     Console.Write(" максимальное -> " + max);
//     Console.Write(" минимальное-> " + min);
//     Console.Write(" разница-> " + difference);
// }
// Difference(min, max);
// Min(array);
// Max(array);
// PrintArray(array, min, max, Difference(min, max));
// FillArray(length);