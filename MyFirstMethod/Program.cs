using System;

namespace MyFirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //CountTo10();
            //CountTo10();
            System.Console.Write("Type a number: ");
            int i = Int32.Parse(Console.ReadLine());
            
            System.Console.Write("Type another number: ");
            int j = Int32.Parse(Console.ReadLine());

            CountToN(i);
            CountToN(j);
            
        }

        private static void CountTo10()
        {
            for(int i = 1; i <= 10; i++)
            {
                System.Console.WriteLine(i);
            }
        }

        private static void CountToN(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
