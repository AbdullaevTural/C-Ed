//Задача 1

// int a = Convert.ToInt32(Console.ReadLine());
// int secondNumber = (a / 10) % 10;
// Console.WriteLine(secondNumber);
//метод 1
// int a = Convert.ToInt32(Console.ReadLine());
// int Method(int st)
// {
//     int secondNumber = (st / 10) % 10;
//     return secondNumber;
// }

// int result = Method(a);
// Console.WriteLine(result);

//Задача 2
// Console.WriteLine("ВВедите число = >" );
// bool Number= int.TryParse(Console.ReadLine(), out int ci);
// Console.WriteLine("Позиция числа  = > ");
// bool Position= int.TryParse(Console.ReadLine(), out int i);
// if(Number != true)
// {
//     Console.WriteLine("Ошибка, введите число");
//     return;
// }
// if(Position != true)
// {
//     Console.WriteLine("Ошибка, введите цифру");
//     return;
// }


// int Method(int ci, int i)
// {
// string ac = ci.ToString();
// int[] arrInt = new int[ac.Length];
// for(int n = 0; n < ac.Length; ++n){ 
//   arrInt[n] = int.Parse(ac[n]+ "");
//   }
// if (i < ac.Length ) {
//     Console.WriteLine("На позиции " + i +" находится цифра" );
//     return arrInt[i-1];
// }
// else {
//     Console.WriteLine("Ошибка, в числе "+ ac +" нет позиции ");
//     return i;
// }
// }
// int result = Method(ci, i);
// Console.WriteLine(result);



//Задача 3

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string Day (int num){
// switch (num)
// {
//     case 1: return ("Понедельник");
//     case 2: return ("Вторник");
//     case 3: return ("Среда");
//     case 4: return ("Четверг");
//     case 5: return ("Пятница");
//     case 6:return ("Суббота");
//     case 7: return ("Воскресенье");
//     default: return ("Ошибка");
// }
// }
// string result = Day(num);
// Console.WriteLine(result);



