using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)

            int main()
        {

            int num1, num2;
            float result;
            int oper;

            Console.WriteLine("Enter +,-,* or /");
            Console.ReadLine("int", oper);
            Console.WriteLine("Enter first number");
            Console.ReadLine("int", oper);
            Console.WriteLine("Enter second number");
            Console.ReadLine("int", oper);

            result = 0;
            switch (oper)


                case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid operaton");

            }

            Console.WriteLine("Result:")



        {
        }
    }
}
