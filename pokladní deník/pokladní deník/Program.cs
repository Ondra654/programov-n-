using System.Runtime.Serialization;
using System.Xml;
using System;
using System.IO;
using System.Text;
using System.Linq;

namespace pokladní_deník
{
    class Program
    {
        static char Menu()
        {
            char input;

            while (true)
            {
                Console.WriteLine("Enter '1' to add/check some item");
                Console.WriteLine("Enter '2' to print values");
                Console.WriteLine("Enter '0' to quit and save file");

                Console.Write("Enter key: ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (input)
                {
                    case '1':
                        return '1';

                    case '2':
                        return '2';

                    case '0':
                        return '0';

                    default:
                        Console.Clear();
                        Console.WriteLine("INVALID OPERATION!");
                        Console.WriteLine();
                        break;
                }
            }
        }

        static int ReadDouble(bool nonZero = false)
        {
            int result;
            bool success;

            do
            {
                string input = Console.ReadLine();
                success = int.TryParse(input, out result) && !(nonZero && result == 0);
                if (!success)
                {
                    Console.WriteLine("\"{0}\" is not a {1}number!", input, nonZero ? "non-zero " : "");
                }
            }
            while (!success);

            return result;
        }

        static string[] ReadLines(TextReader tr)
        {
            string[] lines = new string[5];
            int count = 0;
            string line;
            while ((line = tr.ReadLine()) != null)
            {
                if (count >= lines.Length) { Array.Resize(ref lines, lines.Length * 2); }
                lines[count] = line;
                count++;
            }
            Array.Resize(ref lines, count);
            return lines;
        }
        static void Main(string[] args)
        {
            string BaseDir = @"C:\Users\Ondra\source\repos\pokladní deník\pokladní deník\bin\Debug\netcoreapp3.1\";
            Console.Clear();
            Console.Write("Enter your starting value: ");

            int startvalue = Convert.ToInt32(ReadDouble());

            Console.WriteLine("data in file:");


            
            string[] array;
            
            using (TextReader reader = new StreamReader(BaseDir + "text.txt")) {array = ReadLines(reader); }

            int[] finances = new int[array.Length];

            
            char operation;
            bool successend = true;
            do
            {
                operation = Menu();
                if (operation == '1')
                {
                    bool successedit;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Enter '1' to add item");
                        Console.WriteLine("Enter '2' to delete all data");

                        char menuedit = Console.ReadKey().KeyChar;

                        switch (menuedit)
                        {
                            case '1':
                                Console.Clear();
                                Console.WriteLine("Enter space for array: ");
                                int arrspace = ReadDouble();
                                Array.Resize(ref finances, arrspace);

                                for (int i = 0; i < finances.Length; i++)
                                {
                                    Console.Write("Enter values for item {0}: ", i + 1);
                                    int cases = ReadDouble();
                                    finances[i] = cases;
                                }

                                successedit = true;
                                break;

                            case '2':
                                Console.Clear();
                                Console.WriteLine("all data deleted");
                                Array.Clear(finances, 0, finances.Length);

                                successedit = true;
                                break;

                            default:
                                Console.WriteLine("Invalid input");
                                successedit = false;
                                break;
                        }
                    } while (successedit == false);
                }
                if (operation == '2')
                {
                    Console.Clear();

                    using (TextReader reader = new StreamReader(BaseDir + "text.txt")) {array = ReadLines(reader); }

                    Console.WriteLine("Items list: ");

                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine("Item {0}: {1} Kč", i + 1, array[i]);
                    }
                }
                if (operation == '0')
                {
                    TextWriter wr = new StreamWriter(BaseDir +  "text.txt", false);
                    try
                    {
                        for (int j = 0; j < finances.Length; j++) { wr.WriteLine(finances[j]); }
                    }
                    finally
                    {
                        Console.WriteLine("DONE! \nLook into your file.");
                        if (wr != null) { wr.Dispose(); }
                    }
                    break;
                }

            } while (successend == true);
        }
    }
}
