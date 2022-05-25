using System;

namespace _2022_semestralka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            string[] firstnpc = {"Tyler", "Mike", "Winton", "Brian", "Rowan", "Russell", "Derek", "Harry", "Spencer", "Pedro", "Jamie", "Tyler" };
            Random randomName = new Random();
            string NPCname = firstnpc[randomName.Next(firstnpc.Length)];

            Random randombudget = new Random();
            int NPCbalance = randombudget.Next(5000, 10000);

            Character NPC = new Character(NPCname,NPCbalance);
            
            Console.WriteLine("NPC name and balance: {0} - {1}", NPCname, NPCbalance);

            Console.Write("Enter your nickname: ");
            string nickname = Console.ReadLine();
            Console.Write("Enter your balance: ");
            int balance = Convert.ToInt32(NumberCheck());

            Character player = new Character(nickname, balance);

            bool end = true;
            Console.Clear();
            do {
                char input;

                    Console.WriteLine("Press 'r' to play Roulette");
                    Console.WriteLine("Press b to play Blackjack");
                    
                    Console.WriteLine("Press 'l' to leave casino");

                    Console.Write("Enter key: ");
                    input = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    switch (input)
                    {
                        case 'r':
                        case 'R':
                            Roulette(ref balance, ref nickname);
                            break;

                        case 'b':
                        case 'B':
                            Blackjack(ref balance, ref nickname, ref NPCbalance, ref NPCname);
                            break;

                        case 'l':
                        case 'L':
                            end = false;
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("INVALID OPERATION!");
                            Console.WriteLine();
                            break;
                    }
            } while (end == true);

            Console.WriteLine("You left casino, there are your results: ");
            Console.WriteLine("Nickname: {0}", nickname);
            Console.WriteLine("Your final balance: {0}", balance);

            Console.WriteLine("Press any key when you are ready to leave program");
            Console.ReadKey();
        }
        static void Roulette (ref int balance, ref string nickname)
        {
            Console.Clear();
            Console.WriteLine("ruleta");

            Console.WriteLine("Your balance: {0}", balance);

            /*int[] numbers = new int [37];
            for (int i = 0; i < 37; i++)
            {
                numbers[i] = i + 1;
            }*/
            int[] rednumbers = {1,3,5,7,9,12,14,16,19,18,21,23,25,27,30,32,34,36};
            int[] blacknumbers = {2,4,6,8,10,11,13,15,17,20,22,24,26,28,29,31,33,35};

            /*foreach (int x in numbers)
            {
                Console.WriteLine(x);
            }*/

            Console.WriteLine("┏━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┓");
            for (int i = 0; i < 2; i++)
            {
            Console.WriteLine("┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃");
            Console.WriteLine("┃   ┣━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━┫");
            }
            Console.WriteLine("┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃");
            Console.WriteLine("┗━━━╋━━━┻━━━┻━━━┻━━━╋━━━┻━━━┻━━━┻━━━╋━━━┻━━━┻━━━┻━━━╋━━━┛");
            Console.WriteLine("    ┃    1st 12     ┃    2nd 12     ┃    3nd 12     ┃");
            Console.WriteLine("    ┣━━━━━━━┳━━━━━━━╋━━━━━━━┳━━━━━━━╋━━━━━━━┳━━━━━━━┫");
            Console.WriteLine("    ┃  1-18 ┃       ┃       ┃       ┃       ┃ 19-36 ┃");
            Console.WriteLine("    ┗━━━━━━━┻━━━━━━━┻━━━━━━━┻━━━━━━━┻━━━━━━━┻━━━━━━━┛");

            Console.SetCursorPosition(2, 5);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("0");

            Console.SetCursorPosition(6,3);
            Console.Write("{0} {1} {2} {3}", blacknumbers[2], blacknumbers[7], blacknumbers[11], blacknumbers[16]);

            for (int i = 0; i < rednumbers.Length; i += 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(rednumbers[i]);
            }






            Console.SetCursorPosition(0, 15);
            Console.WriteLine("Set you bet please: ");
            int bet = NumberCheck();
            if (bet < balance)
            {
                Console.WriteLine("bet is higher than your balance!");
                Console.WriteLine("Set you bet please: ");
                bet = NumberCheck();
            }

            Console.WriteLine("Select on what: ");





        }
        static void Blackjack(ref int balance, ref string nickname, ref int NPCbalance, ref string NPCname)
        {
            Console.Clear();
            Console.WriteLine("Blackjack game:");
        }
        static int NumberCheck(bool nonZero = false)
        {
            int result;
            bool success;

            do
            {
                string input = Console.ReadLine();
                success = int.TryParse(input, out result) && !(nonZero && result == 0);
                if (!success)
                {
                    Console.WriteLine("\"{0}\" is not a {1}number!", input, nonZero ? "non-zero": "");
                }
            }
            while (!success);

            return result;
        }
    }
}