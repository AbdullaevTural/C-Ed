//Задача 47.----------------------------------------------------------
// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] mas = new double[m, n];

// void PrintArray(double[,] m)
// {
//     for (int i = 0; i < mas.GetLength(0); i++)
//     {
//         for (int j = 0; j < mas.GetLength(1); j++)
//         {
//             Console.Write($"{m[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// double[,] FillArray(double[,] mas)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < mas.GetLength(0); i++)
//     {
//         for (int j = 0; j < mas.GetLength(1); j++)
//         {
//             mas[i, j] = Convert.ToDouble(rnd.Next(-100, 101)) / 10;

//         }
//     }
//     return mas;
// }

// FillArray(mas);
// PrintArray(mas);


Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] mas = new int[m, n];

void PrintArray(int[,] ma)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{ma[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] FillArray(int[,] ma)
{
    int[,] mass = ma;
    Random rnd = new Random();
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mass[i, j] = rnd.Next(1, 30);
        }
    }
    return mass;

}

FillArray(mas);
PrintArray(mas);

//Задача 50. Напишите программу, которая на вход принимает число и ищет в двумерном массиве, и возвращает индексы этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите число из массива:"); 
int guessNumber = Convert.ToInt32(Console.ReadLine());
string GuessArrayNumber(int[,] array,int number)
{
    string someString = "";
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            if (number == array[i, j])
            {  
                someString = $"{i}, {j}";
                return someString ;
            }
           
        }          
        
    }
    if (someString == "")
            {  
                 Console.WriteLine("нет такого элемента");
            }
    return someString;
}

Console.WriteLine(GuessArrayNumber(mas, guessNumber));




//Задача 52.----------------------------------------------------------------------------------
// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] mas = new int[m, n];

// void PrintArray(int[,] m)
// {
//     for (int i = 0; i < mas.GetLength(0); i++)
//     {
//         for (int j = 0; j < mas.GetLength(1); j++)
//         {
//             Console.Write($"{m[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine("---------------------------");

// }

// int[,] FillArray(int[,] mas)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < mas.GetLength(0); i++)
//     {
//         for (int j = 0; j < mas.GetLength(1); j++)
//         {
//             mas[i, j] = rnd.Next(0, 10);

//         }
//     }
//     return mas;
// }

// void FilArray(int[,] m)
// {
 
//     for (int j = 0; j < mas.GetLength(1); j++)
// {
//     double sum = 0;
//     double avg = 0;
//     for (int i = 0; i < mas.GetLength(0); i++)
//     {
//         sum += m[i, j];
//         avg=  sum / m.GetLength(0);
//     }
//     Console.Write($"{avg} / ");
// }
// }

// FillArray(mas);
// PrintArray(mas);
// FilArray(mas);


