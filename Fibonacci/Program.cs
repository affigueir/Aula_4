using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                int w = Int32.Parse(args[0]);
                System.Console.WriteLine(Fibonacci(w));
            }
            else
            {
                System.Console.Write("Insert a num:");
                int x = Int32.Parse(Console.ReadLine());
                int y = Fibonacci(x);

                System.Console.WriteLine($"The position {x} in fibo is {y}");
            }
        }

        private static int Fibonacci(int n)
        {
            int fibo;

            if (n <= 1)
                fibo = 1;
            else
            {
                fibo = Fibonacci(n - 1) + Fibonacci(n - 2);
            }

            return fibo;

        }
    }
}
