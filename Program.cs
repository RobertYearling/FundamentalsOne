using System;

namespace FundamentialsOne
{
    class Program
    {
        static void Main()
        {
            for(int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
            // *****
            for(int i = 1; i < 100; i++)
            {
                if ((i % 3) == 0)
                {
                    Console.WriteLine(i);
                }
            }
            // *****
            for(int i = 1; i < 100; i++)
            {
                if (((i % 5) == 0) && ((i % 3) == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                if ((i % 3) == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
            // *****
            int i = 1;
            while (i <= 255)
            {
                Console.WriteLine(i);
                i += 1;
            }
            // *****
            int i = 1;
            while (i < 100)
            {
                if ((i % 3) == 0)
                Console.WriteLine(i);
                i += 1;
            }
            // *****
            int i = 1;
            while (i < 100)
            {
                if ((i % 5) == 0)
                Console.WriteLine(i);
                i += 1;
            }
            // *****
            int i = 1;
            while (i < 100)
            {
                if (((i % 3) == 0) && ((i % 5) == 0))
                {
                    Console.WriteLine("FizzBuzz");
                    i += 1;
                }
                else if ((i % 3) == 0)
                {
                    Console.WriteLine("Fizz");
                    i += 1;
                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine("Buzz");
                    i += 1;
                }
                else
                {
                    i += 1;
                }
            }
        }
    }
}

