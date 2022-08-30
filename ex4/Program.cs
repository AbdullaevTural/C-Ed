// Console.WriteLine("Введите x");
// bool isNumberX = int.TryParse(Console.ReadLine(), out int x);

// Console.WriteLine("Введите y");
// bool isNumberY= int.TryParse(Console.ReadLine(), out int y);

// if(isNumberX != true || isNumberY != true)
// {
//     Console.WriteLine("Числа введены не верно.");
//     return;
// }

// bool isValid = Validate(x,y);
// if(isValid == false)
// {
//  Console.WriteLine("Како-то число равно нулю");
//  return;
// }

// int result = GetPosition(x,y);
// Console.WriteLine(result);

// bool Validate(int x, int y)
// {
//     if(x == 0 || y == 0)
//     {
//         return false;
//     }
//     return true;
// }

// int GetPosition(int x, int y)
// {
//     if(x>0 && y>0)
//     {
//         return 1;
//     }

//     if(x < 0 && y > 0)
//     {
//         return 2;
//     }

//     if(x < 0 && y < 0)
//     {
//         return 3;
//     }

//     if(x > 0 && y < 0)
//     {
//         return 4;
//     }
    
//     return -1;
// }



// int Param = Convert.ToInt32(Console.ReadLine());
// string GetCordinats (int param){
//    switch (param)
// {
//     case 1: return "x>0,y>0"; 
//     case 2: return "x<0,y>0"; 
//     case 3: return "x<0,y<0"; 
//     case 4: return "x>0,y<0"; 
//     default: return ("Ошибка"); 
// }
// }
// string result = GetCordinats(Param);
// Console.WriteLine(result);


int X1 = Convert.ToInt32(Console.ReadLine());
int Y1 = Convert.ToInt32(Console.ReadLine());
int X2 = Convert.ToInt32(Console.ReadLine());
int Y2 = Convert.ToInt32(Console.ReadLine());


double Method (double X1, double  X2, double Y1, double Y2 ){
  double sb = Math.Sqrt(Math.Pow((X2-X1),2)+ Math.Pow((Y2-Y1),2));
  return  sb;
}
double result = Method(X1,X2,Y1,Y2);
Console.WriteLine(result);

// int ci = Convert.ToInt32(Console.ReadLine());

// for(int n = 1; n <= ci; ++n){
//     int arn = n*n;
// }
// Console.WriteLine(arn); 



