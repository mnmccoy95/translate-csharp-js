using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int n=0; n<=100; n++)
            {
                if(n % 15 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                if(n % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                if(n % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
