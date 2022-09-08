int a = Convert.ToInt32(Console.ReadLine());
int [] b = new int [a];
for (int n = 0; n < a+1; n++)
    {   b[0] = 0;
        b[1] = 1;
        b[n] = b[n-1] + n[n-2];
        Console.Write(b[n]);
        }


     for (int i = (b.Length - 1); i >= 0; i--)
        {
           Console.Write(b[i]);
        }
        