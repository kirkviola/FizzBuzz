using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Checks numbers 1 - 30; replaces divisible by 3 as "Fizz"
            // Divisible by 5 as "Buzz", and divisible by both as "FizzBuzz"
            for (var idx = 1; idx <= 30; idx++)
            {
                if (idx % 3 == 0 && idx %5 == 0)
                    Console.Write("FizzBuzz ");
                else if (idx % 3 == 0)
                    Console.Write("Fizz ");
                else if (idx % 5 == 0)
                    Console.Write("Buzz ");
                else
                    Console.Write($"{idx} ");
            }


            //Let's try the same thing with a ternary
            //for (var idx = 1; idx <= 30; idx++)
            //{
            //    if (idx % 3 == 0 && idx % 5 == 0)
            //        Console.Write("FIZZBUZZ ");
            //    else if (idx % 3 == 0)
            //        Console.Write("FIZZ ");
            //    else
            //    {
            //        idx = (idx % 5 == 0)
            //            ? Convert.ToString("BUZZ") : idx;

            //    }
            //}

        }
    }
}
