int n = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int[] arrInt = new int[n];

    for (int i = 0; i < n; i++)
    {
        arrInt[i] = rnd.Next(0, 2);
    }

void PrintArray(int[] arrInt)
{
    for (int i = 0; i < arrInt.Length; i++)
    {
        Console.Write($"{arrInt[i]}  ");
    }
}
PrintArray(arrInt);