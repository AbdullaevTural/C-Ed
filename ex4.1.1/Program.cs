
// //Задача 27

// int ci = Convert.ToInt32(Console.ReadLine());

// int SumNumber(int ci)
// {
// string ac = ci.ToString();
// int Number = 0;
// int[] arrInt = new int[ac.Length];
// for(int n = 0; n < ac.Length; ++n){ 
//   arrInt[n] = int.Parse(ac[n]+ "");
//   Number = Number + arrInt[n];
//   }
//    return Number;
// }
// int result = SumNumber(ci);
// Console.WriteLine(result);


// //Задача 25 

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// int Step(int a, int b)
// {
//     int sumStep = a;
//     for (int n = 1; n < b; ++n)
//     {
//         a *= sumStep;
//     }
//     return a;
// }
// int result = Step(a, b);
// Console.WriteLine(result);


// //Задача 29



int[] a = new int[8];
Console.WriteLine("Введите массив чисел: ");
for (int i = 0; i < 8; i++)
{
a[i] = int.Parse(Console.ReadLine());
}



void PrintArray(int[] a)
{
    if(a.Length == 0)
    {
        Console.WriteLine("Что-то пошло не так");
        return;
    }
    Console.Write("[");

    for (int i = 0; i < a.Length - 1; i++)
    {
        Console.Write($"{a[i]},");
    }

    Console.Write(a[a.Length - 1]);
    Console.Write("]");
}
PrintArray(a);

