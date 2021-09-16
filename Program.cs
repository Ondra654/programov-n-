using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Speak, friend and Enter: ");
            string password = Console.ReadLine();

            if (password != "lol")
            {
                Console.WriteLine("Wrong password");
                Console.WriteLine("Press any key...");
                Console.ReadKey();

                return;
            }
            Console.WriteLine("You may now enter.");
            Console.WriteLine("Please input a number ");
            string input = Console.ReadLine();
            int result;


            bool success = int.TryParse(input, out result);
            while (!success)
            {
                Console.WriteLine("\"{0}\" is not a number:", input);
                Console.WriteLine("Please type a number: ");
                input = Console.ReadLine();
                success = int.TryParse(input, out result);
            }

            Console.WriteLine("You typed:{0}", result);


            bool success2;
            int result2;

            do
            {
                Console.WriteLine("Please type a positive number");
                string input2 = Console.ReadLine();
                success2 = int.TryParse(input2, out result2);
            } while (!(success2 && result2 > 0));

            Console.WriteLine("You typed: {0}", result2);


            int sum = 0;
            for (int i = 1; i <=10; i +=1) {
                sum += 1;

                Console.WriteLine("i={0}, sum={1}", i, sum);
            }

            Console.WriteLine("Sum is: {0}", sum);

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
