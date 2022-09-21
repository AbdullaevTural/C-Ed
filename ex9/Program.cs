//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Console.WriteLine("Введите начальное число");
// bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
// Console.WriteLine("Введите конечное число");
// bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
// if (!isNumberM || m <= 0 || !isNumberN || n <= 0)
// {
//     Console.WriteLine("Ввели неправильное число");
//     return;
// }

// int[] arrInt = new int[n + 1];

// int[] FillArray(int startNumber, int lastNumber)
// {

//     for (int i = startNumber; i <= lastNumber; i++)
//     {
//         arrInt[i] = i;
//     }
//     return arrInt;
// }
// void PrintArray(int[] array)
// {
//     if (array.Length == 0)
//     {
//         Console.WriteLine("Что-то пошло не так");
//         return;
//     }
//     Console.Write("\"\"");

//     for (int i = m; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]},");
//     }

//     Console.Write(array[array.Length - 1]);
//     Console.Write("\"\"");
// }
// FillArray(m,n);
// PrintArray(arrInt);
///// -------- 2 вариант рекурсия
// Console.WriteLine("Введите начальное число");
// bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
// Console.WriteLine("Введите конечное число");
// bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
// if (!isNumberM || m <= 0 || !isNumberN || n <= 0)
// {
//     Console.WriteLine("Ввели неправильное число");
//     return;
// }
// string NumersRec(int M, int N)
// {
//     if (M < N) return $"{M}, " + NumersRec(++M, N);
//     else return $"{M}";
// }

// Console.Write(NumersRec(m, n));

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Console.WriteLine("Введите начальное число");
// bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
// Console.WriteLine("Введите конечное число");
// bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
// if (!isNumberM || m <= 0 || !isNumberN || n <= 0)
// {
//     Console.WriteLine("Ввели неправильное число");
//     return;
// }

// int[] arrInt = new int[n + 1];
// int sumNumbers = 0;
// int FillArray(int startNumber, int lastNumber)
// {

//     for (int i = startNumber; i <= lastNumber; i++)
//     {
//         arrInt[i] = i;
//         sumNumbers =  sumNumbers + arrInt[i];
//     }
//     return sumNumbers;
// }
// void PrintArray(int sum)
// {
//     if (sum == 0)
//     {
//         Console.WriteLine("Что-то пошло не так");
//         return;
//     }
//     Console.Write("->" + sumNumbers);
// }
// FillArray(m,n);
// PrintArray(sumNumbers);
/// -------- 2 вариант рекурсия
// Console.WriteLine("Введите начальное число");
// bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
// Console.WriteLine("Введите конечное число");
// bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
// if (!isNumberM || m <= 0 || !isNumberN || n <= 0)
// {
//     Console.WriteLine("Ввели неправильное число");
//     return;
// }
// int sum = 0;
// int NumersRec(int M, int N)
// {
//     if (M <= N)
//     {
//         sum = M + NumersRec(++M, N);
//     }
//     return sum;
// }

// Console.Write(NumersRec(m, n));

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите начальное число");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите конечное число");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);


int NumersRec(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return NumersRec(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return NumersRec(m - 1, NumersRec(m, n - 1));
    }
    else
        return n + 1;
}

Console.Write(NumersRec(m, n));
