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

            
            int[] rednumbers = {1,3,5,7,9,12,14,16,19,18,21,23,25,27,30,32,34,36};
            int[] blacknumbers = {2,4,6,8,10,11,13,15,17,20,22,24,26,28,29,31,33,35};

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


            int[] rednumbers1 = {3,9,12,18,21,27,30,36,5,14,23,32,1,7,16,25,28,34};

            int[] blacknumbers1 = {6,15,24,33,2,8,11,17,20,26,29,35,4,10,13,19,22,31};

            int x1 = 6;
            int y1 = 3;
            for (int i = 0; i < 1; i++){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(x1, y1);
                Console.Write(rednumbers1[i]);
                x1 = x1 + 8;
                for (int i1 = 1; i1 < 8; i1++){
                    Console.SetCursorPosition(x1, y1);
                    Console.Write(rednumbers1[i1]);
                    x1 = x1 + 4;
                    if (i1 == 2){
                        x1 = x1 + 4;
                    }
                    if (i1 == 4){
                        x1 = x1 + 4;
                    }
                    if (i1 == 6){
                        x1 = x1 + 4;
                    }
                }Console.ForegroundColor = ConsoleColor.White;
            }
            x1 = 10;
            y1 = 3;
            for (int i = 0; i < 4; i++){
                Console.SetCursorPosition(x1, y1);
                Console.Write(blacknumbers1[i]);
                x1 = x1 + 12;
            }
            x1 = 6;
            y1 = 5;
            for (int i = 4; i < 5; i++){
                Console.SetCursorPosition(x1, y1);
                Console.Write(blacknumbers1[i]);
                x1 = x1 + 8;
                for (int i1 = 5; i1 < 12; i1++){
                    Console.SetCursorPosition(x1, y1);
                    Console.Write(blacknumbers1[i1]);
                    x1 = x1 + 4;
                    if (i1 == 6){
                        x1 = x1 + 4;
                    }
                    if (i1 == 8){
                        x1 = x1 + 4;
                    }
                    if (i1 == 10){
                        x1 = x1 + 4;
                    }
                }
            }
            x1 = 10;
            y1 = 5;
            for (int i = 8; i < 12; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(x1, y1);
                Console.Write(rednumbers1[i]);
                x1 = x1 + 12;
                Console.ForegroundColor = ConsoleColor.White;
            }
            x1 = 6;
            y1 = 7;
            for (int i = 12; i < 13; i++){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(x1, y1);
                Console.Write(rednumbers1[i]);
                x1 = x1 + 8;
                for (int i1 = 13; i1 < 18; i1++){
                    Console.SetCursorPosition(x1, y1);
                    Console.Write(rednumbers1[i1]);
                    x1 = x1 + 12;
                    if (i1 == 14){
                        x1 = 38;
                    }
                    if (i1 == 15){
                        x1 = 42;
                    }
                    if (i1 == 16){
                        x1 = 50;
                    }
                }Console.ForegroundColor = ConsoleColor.White;
            }
            x1 = 10;
            y1 = 7;
            for (int i = 12; i < 13; i++){
                Console.SetCursorPosition(x1, y1);
                Console.Write(blacknumbers1[i]);
                x1 = x1 + 8;
                for (int i1 = 13; i1 < 18; i1++){
                    Console.SetCursorPosition(x1, y1);
                    Console.Write(blacknumbers1[i1]);
                    x1 = x1 + 4;
                    if (i1 == 14){
                        x1 = x1 + 4;
                    }
                    if (i1 == 16){
                        x1 = x1 + 8;
                    }
                }
            }

            Console.SetCursorPosition(2, 5);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("0");


            Console.SetCursorPosition(0, 20);
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