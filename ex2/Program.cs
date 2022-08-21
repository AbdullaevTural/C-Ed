

Console.Write("n = ");
int a = int.Parse(Console.ReadLine());

if (n / 1000 > 0) Console.WriteLine("Invalid number");
else {
    int sum = 0, prod = 1;
    while (n > 0) {
        int rem;
        n = Math.DivRem(n, 10, out rem);
        sum += rem;
        prod *= rem;
    }
    Console.WriteLine("Sum = {0}", sum);
    Console.WriteLine("Product = {0}", prod);
}
