
// //Задача 1 
// Console.WriteLine("Введите пятизначное число для проверки:");
// bool isNumber= int.TryParse(Console.ReadLine(), out int Number);
// if(isNumber != true )
// {
//     Console.WriteLine("Это не число!");
//     return;
// }
// if(Number <  0 )
// {
//     Number = Number  * -1;
    
// }
// string NumInStr = Number.ToString();
// string revers = "";
// if(Number / 100000 !=  0 )
// {
//     Console.WriteLine("Это не пятизначное число!");
//     return;
// }
// void GetCordinats (string s, string revers ) {
// for (int i = s.Length - 1; i >= 0; i--) {
// revers = revers + s[i].ToString();
// }
//  int result = Int32.Parse(revers);
//   if (Number == result) {
//     Console.WriteLine("Да");  
//   }
//  else{
//     Console.WriteLine("Нет");  
//   }
//  }

// GetCordinats(NumInStr, revers );

// //Задача 2
// Console.WriteLine("Введите положение первой точки по x");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите положение первой точки по y");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите положение первой точки по z");
// int Z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите положение второй точки по x");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите положение второй точки по y");
// int Y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите положение второй точки по z");
// int Z2 = Convert.ToInt32(Console.ReadLine());

// double distance (double X1, double Y1, double Z1, double  X2,  double Y2,  double Z2 ){
//   double sMath = Math.Sqrt(Math.Pow((X2-X1),2)+ Math.Pow((Y2-Y1),2) + Math.Pow((Z2-Z1),2));
//   return  sMath;
// }
// double result = distance(X1,Y1,Z1,X2,Y2,Z2);
// Console.WriteLine("Расстояние между точками в 3D пространстве = " + result);

// //Задача 3

bool isNumber = int.TryParse(Console.ReadLine(), out int N);
if(isNumber != true )
{
    Console.WriteLine("Это не число!");
    return;
}


  int[] arrInt = new int[N+1];
  double cubeNumber = 0.0;
   int cubeNumbers = 0;
    for (int i = 0; i < arrInt.Length; i++)
    {
      cubeNumber = Math.Pow(i,3);
      cubeNumbers = Convert.ToInt32(cubeNumber);
      arrInt[i] = cubeNumbers;
    }
    
void PrintArray(int[] arrInt)
{
    for (int i = 1; i < arrInt.Length; i++)
    {
        Console.Write($"{arrInt[i]}  ");
    }
}
PrintArray(arrInt);





