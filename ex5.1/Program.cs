// Console.WriteLine("Enter length - ");



// bool isNumber = int.TryParse(Console.ReadLine(), out int length);
// if (!isNumber || length <= 0)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

// int[] array = FillArray(length);
// PrintArray(array);
// int [] revArray = PrintArrayOtr(array);
// PrintArray(revArray);

// void PrintArray(int[] array)
// {
//     if(array.Length == 0)
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
// }

//  int [] PrintArrayOtr(int[] array)
// {
//     if(array.Length == 0)
//     {
//         Console.WriteLine("Что-то пошло не так"); 
//     }
//         for (int i = 0; i < array.Length; i++){
//             array[i] = array[i] * -1;
//         }
//         return array;
// }

// int[] FillArray(int length)
// {
//     int[] array = new int[length];
    
//     Random random = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = random.Next(-10, 11);
//     }
//     return array;
// }



Console.WriteLine("Enter length - ");



bool isNumber = int.TryParse(Console.ReadLine(), out int length);
if (!isNumber || length <= 0)
{
    Console.WriteLine("Invalid number");
    return;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(0, 124);
    }
    return array;
}

void PrintArray(int[] array)
{
    if(array.Length == 0)
    {
        Console.WriteLine("Что-то пошло не так");
        return;
    }
    Console.Write("[");

    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }

    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

int[] array = FillArray(length);
PrintArray(array);

 int [] PrintArrayOtr(int[] array)
{
    
        for (int i = 0; i < array.Length; i++){
        if(array[i] == array[100] )
    {
       
    }
}
}