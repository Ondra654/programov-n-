using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int max;
            bool success;

            do
            {
                Console.WriteLine("Please enter a max.number:");
                success = int.TryParse(Console.ReadLine(), out max) && max > 0;
                if (!success)
                {
                    Console.WriteLine("That´s not a number");
                }


            } while (!success);


             bool[] isPrime = new bool[max - 1];
             for (int i = 0; i < isPrime.Length; i += 1)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i * i <= max; i += 1)
            {
                if (isPrime[i - 2])
                {
                    for (int j = i * i; j <= max; j += i)
                    {
                        isPrime[j - 2] = false;
                    }
                }
            }

            for (int i = 2; i <= max; i += 1)
            {
                if (isPrime[i - 2])
                {
                    Console.WriteLine(i);
                }

            }

            Console.WriteLine("Press any key");
            Console.ReadKey();


        }
    }
}
