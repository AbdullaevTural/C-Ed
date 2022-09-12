//  Console.WriteLine("Введите длину массива");
// bool isNumber = int.TryParse(Console.ReadLine(), out int length);
// if (!isNumber || length <= 0)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }


// int[] FillArray(int length)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//          Console.WriteLine("Введите число для массива");
//         array[i] = int.Parse(Console.ReadLine());
//     }
//     return array;
// }
// int[] array = FillArray(length);
// int sum = 0;
// int Sumpol(int[] array)
// {
//     for (int i = 0; i < length; i++)
//     {
//         if (array[i] > 0){
//         sum = ++sum;
//         }
//     }
//     return sum;
// }
// Sumpol(array);

// void PrintArray(int[] array, int sum)
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
//     Console.Write("->" + sum);
// }
// PrintArray(array, sum);


//  Console.WriteLine("Введите точку");
// bool isNumberB1 = double.TryParse(Console.ReadLine(), out double b1);
// bool isNumberB2 = double.TryParse(Console.ReadLine(), out double b2);
// bool isNumberK1 = double.TryParse(Console.ReadLine(), out double k1);
// bool isNumberK2 = double.TryParse(Console.ReadLine(), out double k2);

// if (!isNumberB1 || !isNumberB2 || !isNumberK1 || !isNumberK2)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
       
Console.WriteLine("Введите точку b1");
bool isNumberB1 = double.TryParse(Console.ReadLine(), out double b1);
Console.WriteLine("Введите точку b2");
bool isNumberB2 = double.TryParse(Console.ReadLine(), out double b2);
Console.WriteLine("Введите точку k1");
bool isNumberK1 = double.TryParse(Console.ReadLine(), out double k1);
Console.WriteLine("Введите точку k2");
bool isNumberK2 = double.TryParse(Console.ReadLine(), out double k2);

if (!isNumberB1 || !isNumberB2 || !isNumberK1 || !isNumberK2)
{
    Console.WriteLine("Invalid number");
    return;
}
      
  
  Dictionary<int, string> dict = new()
            {
                { -1, "Параллельны" },
                { 0, "Совпадают" },
                { 1, "Пересекаются" }
            };
 
 
            int r = LineCross( b1, k1, b2, k2, out Point p );
            Console.WriteLine( r == 1 ? $"Прямые {dict[ r ]} в точке: ({p.x};{p.y})" : $"Прямые {dict[ r ]}" );
            Console.WriteLine(); 
           
        
        int LineCross(double b1, double k1, double b2, double k2, out Point p )
        {
            
            int res;
            p = new Point( 0.0, 0.0 );
            Console.WriteLine( $"1 Прямая: {k1}x + {b1} = 0" );
            Console.WriteLine( $"2 Прямая: {k2}x + {b2} = 0" );
            
 
            if ( k1 - k2 == 0 )
            {
                res = -1; //Параллельны
                if ( k1 - k2 == 0 &&  b1 - b2  == 0 ) res = 0;    //Совпадают
            }
            else res = 1;   //Пересекаются
 
        // Вычисление точки пересечения
            
            p.y = (k1*(b2-b1))/(k1-k2)+b1;
            p.x = (b2-b1)/(k1-k2);
            return res;
        }

        // Структура точки (координата)
        struct Point
        {
            public double x;
            public double y;
            public Point( double x, double y )
            {
                this.x = x;
                this.y = y;
            }
        }
   