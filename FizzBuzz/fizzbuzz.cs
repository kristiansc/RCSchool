using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            long maxNumber;
            Console.WriteLine("Lūdzu ievadi maksimālo skaitli, līdz kuram izvadīt skaitļus");
            maxNumber = long.Parse(Console.ReadLine());

            for (long i = 1; i <= maxNumber; i++)
            {
                int dalitajs3 = 3;
                int dalitajs5 = 5;
                long fizz = i % dalitajs3;
                long buzz = i % dalitajs5;
                if (fizz == 0 && buzz == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (fizz == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (buzz == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadLine();
        }
    }
}
