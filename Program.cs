using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
        double result = 0;
        double a, b;
        string oper;
        bool success = true;
            Console.WriteLine("Enter +, -, *,/");
            oper = (Console.ReadLine ());
            Console.WriteLine("Enter a number");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a number");
            b = Convert.ToDouble(Console.ReadLine());

            switch (oper)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    if (b == 0) {
                        success = false;
                        Console.WriteLine("No options");
                    }
                    result = a / b;
                    break;
            }
            if (success == true)
            {
                Console.WriteLine("result:{0}{1}{2}={3}", a, oper, b, result);
            }
            else
                Console.WriteLine("Try again");


             Console.WriteLine("Press any key");
             Console.ReadKey();

           



        }
    }
}
