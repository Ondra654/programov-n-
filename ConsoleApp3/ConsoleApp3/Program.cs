using System;

namespace ConsoleApp1
{
    class Program
    {
        static char Menu()
        {// menu celého programu - rozcestník pro jednotlivé možnosti programu
            char input;
                              
            while (true)
            {
                Console.WriteLine("Enter 'a' to rewrite number of days and theirs data");
                Console.WriteLine("Enter 'd' to delete data");
                Console.WriteLine("Enter 's' to open data list");
                Console.WriteLine("Enter 't' to check max, min, avg, data/1OOk and R numbers");
                Console.WriteLine("Enter 'q' to quit program");

                Console.Write("Enter key: ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (input)
                {
                    case 'a':
                    case 'A':
                        return 'A';

                    case 'd':
                    case 'D':
                        return 'D';

                    case 's':
                    case 'S':
                        return 'S';

                    case 't':
                    case 'T':
                        return 'T';

                    case 'q':
                    case 'Q':
                        return 'Q';

                    default:
                        Console.Clear();
                        Console.WriteLine("INVALID OPERATION!");
                        Console.WriteLine();
                        break;
                }
            }
        }
        static int ReadDouble(bool nonZero = false)//v celém programu kontroluje, zda jsou zadaná čísla opravdu čísla
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
        static void Main(string[] args)
        {
            Console.Title = "Covid data";

            char oper;

            Console.Write("How many days? Enter number: "); //program chce vědět, kolik arrayů má vytvořit
            int A = Convert.ToInt32(ReadDouble());
            int[] numbers = new int[A];
 
            int i;
            for (i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter numbers for day {0}: ", i + 1); //program chce zadat data k jednotlivým arrayům
                int cases = ReadDouble();
                numbers[i] = cases;
            }
            
            bool successend = true;
            Console.Clear();
            do
            {//níže program čte zadanou klávesu v menu a otevře danou možnost (q,a,d,s,t)
                oper = Menu();

                if (oper == 'T') //možnost v menu zobrazit statistiky dat                  
                {
                    Console.Clear();
                    int min = int.MaxValue; 
                    int max = int.MinValue; 

                    int sum = 0;
                    int inhabitants = 10702942;
                    int daymax = 0;
                    int daymin = 0;

                    foreach (int item in numbers)
                    {
                        if (item < min)
                        { 
                            min = item;
                            for (int day = 0; day < numbers.Length; day++)
                            {
                                
                                if (numbers[day] < min)
                                {
                                    min = numbers[day];
                                    daymin = day;
                                }
                            }
                        }

                        if (item > max)
                        { 
                            max = item;
                            for (int day1 = 0; day1 < numbers.Length; day1++)
                            {
                                
                                if (numbers[day1] > max)
                                {
                                    max = numbers[day1];
                                    daymax = day1;
                                }
                            }

                        }
                        sum += item;
                    }
                    Console.WriteLine("There you can check minimum, maximum, sum total and average numbers of infected: ");
                    Console.WriteLine();
                    Console.WriteLine("Minimum data: {0} infected on day {1}", min, daymin + 1);
                    Console.WriteLine();
                    Console.WriteLine("Maximum data: {0} infected on day {1}", max, daymax + 1);
                    Console.WriteLine();
                    Console.WriteLine("sum total: {0} infected", sum);
                    Console.WriteLine();
                    Console.WriteLine("average per day: {0} infected", (int)sum / numbers.Length);
                    Console.WriteLine();
                    Console.WriteLine("infected / 100k inhabitants: {0} infected/100k inhabitants", (int)(sum * 100000) / inhabitants);
                    Console.WriteLine();
                    double R = 0;
                    for (int rdata = 0; rdata < numbers.Length; rdata++)//výpočet hodnoty R
                    {
                        if (rdata >= 14)
                        {
                            double week1 = numbers[rdata] + numbers[rdata - 1] + numbers[rdata - 2] + numbers[rdata - 3] + numbers[rdata - 4] + numbers[rdata - 5] + numbers[rdata - 6];
                            double week2 = numbers[rdata - 7] + numbers[rdata - 8] + numbers[rdata - 9] + numbers[rdata - 10] + numbers[rdata - 11] + numbers[rdata - 12] + numbers[rdata - 13];
                            R = week1 / week2;
                        }

                        if (rdata < 11)
                        {
                            Console.WriteLine("R number for day {0}: no way to calculate", rdata + 1, numbers[rdata]);
                        }
                        else
                        {
                            Console.WriteLine("R number for day {0}: {2}", rdata + 1, numbers[rdata], Math.Round(R, 2));
                        }

                    }

                    Console.WriteLine();
                }

                if (oper == 'Q') //monžnost v menu ukončit program
                {
                    break;
                }

                if (oper == 'A') //možnost v menu přepsat data arrayů - jejich počet a jejich hodnoty
                {
                    bool successedit;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("What do you want to edit?");
                        Console.WriteLine("Enter '1' to edit  particular day");
                        Console.WriteLine("Enter '2' to edit number of days and theirs data");
                        Console.Write("Know enter number please: ");
                        char menuedit = Console.ReadKey().KeyChar;
                        Console.WriteLine();

                        switch (menuedit)
                        {
                            case '1': //přepsání dat u konkrétního arraye
                                Console.Clear();
                                Console.Write("Enter which day do you want to edit: ");
                                int editday = ReadDouble();
                                while (editday > numbers.Length)
                                {
                                    Console.WriteLine("number {0} is higher than number of days! Try lower number...", editday);
                                    Console.WriteLine("Enter which day do you want to edit: ");
                                    editday = ReadDouble();
                                }
                                    Console.Write("Enter numbers for day {0}: ", editday);
                                    int editcases = ReadDouble();
                                    numbers[editday -1] = editcases;
                             
                                successedit = true;
                                break;

                            case '2'://přepsání počtu arrayů a jejich dat
                                Console.Clear();
                                Console.Write("How many days? Enter number: ");
                                int B = Convert.ToInt32(ReadDouble());
                                numbers = new int[B];

                                int i1;
                                for (i1 = 0; i1 < numbers.Length; i1++)
                                {
                                    Console.Write("Enter numbers for day {0}: ", i1 + 1);
                                    int cases = ReadDouble();
                                    numbers[i1] = cases;
                                }
                                Console.Clear();

                                successedit = true;
                                break;

                            default:
                                Console.WriteLine("Invalid input");
                                successedit = false;
                                break;
                        }
                    } while (successedit == false);
                }

                if (oper == 'D') //možnost v menu mazat data arrayů, mazání od konce/od začátku/smazání všech dat - podle toho co se zadá za hodnotu...
                {
                    Console.Clear();
                    Console.Write("How many days do you want clear? ");
                    int del = ReadDouble();
                  
                   if (del < 0)//maže data od začátku
                    {
                        Array.Reverse(numbers);
                        Array.Resize(ref numbers, numbers.Length - del);
                        Array.Reverse(numbers);
                        Console.WriteLine("New data list: ");
                        Console.WriteLine();
                        for (int iclear = 0; iclear < numbers.Length; iclear++)
                        {
                            Console.WriteLine("Day {0}: {1} infected", iclear + 1, numbers[iclear]);
                        }
                        Console.WriteLine();
                    }
                    if (del > 0)//maže data od konce
                    {
                        del = Math.Abs(del);
                        Array.Resize(ref numbers, numbers.Length - del);
                        Console.WriteLine("New data list: ");
                        Console.WriteLine();
                        for (int iclear = 0; iclear < numbers.Length; iclear++)
                        {
                            Console.WriteLine("Day {0}: {1} infected", iclear + 1, numbers[iclear]);
                        }
                        Console.WriteLine();
                    }
                    if (del == 0)//smaže všechny data
                    {
                        Array.Clear(numbers, 0, numbers.Length);
                        Console.WriteLine("DATA LIST IS COMPLETELY CLEAR KNOW!");
                        Console.WriteLine();
                    }
                }

                if (oper == 'S') //možnost v menu zobrazit data list arrayů
                {
                    bool successmenu;
                    do 
                    {
                        Console.Clear();
                        Console.WriteLine("What data do you want to check? ");
                        Console.WriteLine("Press '1' to show all days");
                        Console.WriteLine("Press '2' to show specific days");
                        Console.WriteLine("Press '3' to show one specific day");
                        Console.Write("Know enter number please: ");
                        char menuin = Console.ReadKey().KeyChar;

                        Console.WriteLine();

                        switch (menuin)
                        {
                            case '1'://data list všech dnů a jejich dat
                                Console.Clear();
                                Console.WriteLine("Data list: ");

                                for (i = 0; i < numbers.Length; i += 1)
                                {
                                    Console.WriteLine("Day {0} - {1} infected", i + 1, numbers[i]);
                                }
                                successmenu = true;
                                break;

                            case '2'://data list ze zadaného výběru
                                Console.Clear();
                                Console.WriteLine("Which days do you want check? Enter range please!");
                                Console.Write("First day: ");
                                int firstday = ReadDouble();
                                Console.Write("Ending day: ");
                                int endday = ReadDouble();
                                
                                while (endday > numbers.Length)
                                {
                                    Console.WriteLine("Day {0} isn´t on the list", endday);
                                    Console.Write("Ending day: ");
                                    endday = ReadDouble();
                                }

                                Console.Clear();
                                Console.WriteLine("Data list:");

                                do
                                {
                                Console.WriteLine("Data for day {0}: {1}", firstday, numbers[firstday-1]);
                                    firstday++;
                                } while (firstday <= endday);

                                successmenu = true;
                                break;

                            case '3'://data z konkrétního zadaného dne
                                Console.Clear();
                                Console.WriteLine("Enter which day do you want to check");
                                Console.Write("Your choice: ");
                                int oneday = ReadDouble();
                                oneday = oneday - 1;
                                while (oneday > numbers.Length)
                                {
                                    Console.WriteLine("Day {0} isn´t on the list", oneday);
                                    Console.Write("Your choice: ");
                                    oneday = ReadDouble();
                                }
                                Console.Clear();

                                Console.WriteLine("Data for day {0}: {1} infected", oneday + 1, numbers[oneday]);
                                
                                successmenu = true;
                                break;

                            default:
                                Console.WriteLine("Invalid input");
                                successmenu = false;
                                break;
                        }
                        Console.WriteLine();
                    } while (successmenu == false);
                
                }
            } while (successend == true);

            Console.WriteLine();
            Console.Write("Now you can quit program, press any key...");
            Console.ReadKey();
        }
    }
}
