using System;

namespace pertla
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, m, ok, bp;
            n = double.Parse(Console.ReadLine());
            m = double.Parse(Console.ReadLine());

            bp = Math.Truncate(n / m);
            ok = n - (m * bp);

            Console.WriteLine(bp);
            Console.WriteLine(ok);
        }
    }
}