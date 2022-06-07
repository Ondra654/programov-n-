using System;

namespace _2022_semestralka
{
    class Program
    {
        static char Menu()
        {
            Console.Write("Enter your nickname: ");
            string nickname = Console.ReadLine();
            Console.Write("Enter your balance: ");
            int balance = Convert.ToInt32(NumberCheck());

            Character player = new Character(nickname, balance);
            char input;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Press 'r' to play Roulette");
                Console.WriteLine("Press 'b' to play Blackjack");
                Console.WriteLine("Press 'o' to play Odds");

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
                        Blackjack(ref balance, ref nickname);
                        break;

                    case 'o':
                    case 'O':
                        Odds(ref balance, ref nickname);
                        break;

                    case 'l':
                    case 'L':
                        Console.Clear();
                        Console.WriteLine("You left casino, there are your results: ");
                        Console.WriteLine("{0} with final balance: {1}", nickname, balance);
                        Console.Write("Press any key to leave:");
                        Console.ReadLine();
                        Environment.Exit(1);                        
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("INVALID OPERATION!");
                        Console.WriteLine();
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.Title = "Casino game";
            char operation;
            operation = Menu();
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


            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 20);
            Console.Write("Set you bet please: ");
            int bet = NumberCheck();
            bool success = true;
            do
            {
                if (bet > balance){
                    Console.WriteLine("bet is higher than your balance!");
                    Console.Write("Set you bet please: ");
                    bet = NumberCheck();
                }
                if (bet < balance){
                    break;
                }
            } while (success == true);

            Console.WriteLine("Select on what: ");

            balance = balance - bet;
            Console.WriteLine("test - {0}", balance);
        }
        static void Blackjack(ref int balance, ref string nickname)
        {
            Console.Clear();
            Console.WriteLine("Blackjack game:");
        }
        static void Odds(ref int balance, ref string nickname)
        {
            Console.Clear();
            Console.WriteLine("Welcome, there are live odds:");
            Random rand = new Random();
            double odd1 = NextDouble(rand, 1.00, 3.27, 2);
            rand = new Random();
            double odd2 = NextDouble(rand, 1.00, 3.27, 2);

            double odd3 = NextDouble(rand, 1.05, 1.28, 2);
            rand = new Random();
            double odd4 = NextDouble(rand, 2.10, 3.20, 2);

            double odd5 = NextDouble(rand, 2.73, 4.55, 2);
            rand = new Random();
            double odd6 = NextDouble(rand, 1.02, 1.10, 2);
            rand = new Random();
            double oddresult = rand.Next(1, 2);
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("┃      Champions league final:      ┃      Tennis match:        ┃               F1 Monaco race:               ┃");
            Console.WriteLine("     ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("┃      Liverpool x Real Madrid      ┃    Federer x Djokovic     ┃   Verstappen(Redbull) x Leclerc(Ferrari)    ┃");

            Console.SetCursorPosition(5, 6);
            Console.WriteLine("           {0}  ┃  {1}                   {2}  ┃  {3}                          {4}  ┃  {5}", odd1,odd2,odd3,odd4,odd5,odd6);

            Console.Write("First of all enter your bet value please: ");
            int ODDbet = Convert.ToInt32(NumberCheck());
            bool success = true;
            do
            {
                if (ODDbet > balance)
                {
                    Console.WriteLine("bet is higher than your balance!");
                    Console.Write("Set you bet please: ");
                    ODDbet = NumberCheck();
                }
                if (ODDbet < balance)
                {
                    break;
                }
            } while (success == true);
            bool end = true;
            do
            {
                Console.WriteLine("Enter '1' and bet on Liverpool win");
                Console.WriteLine("Enter '2' and bet on Real Madrid win");
                Console.WriteLine("Enter '3' and bet on Federer win");
                Console.WriteLine("Enter '4' and bet on Djokovic win");
                Console.WriteLine("Enter '5' and bet on Verstappen race win");
                Console.WriteLine("Enter '6' and bet on Leclerc race win");
                Console.Write("Select odd if you want to bet, or enter '0' to leave odds: ");
                char answer = Console.ReadKey().KeyChar;
                switch (answer)
                {
                    case '1':
                        double Pwin = ODDbet * odd1;
                        Console.Clear();
                        Console.WriteLine("Bet {0} on Liverpool win - Potencional win: {1}", ODDbet, Pwin);
                        if (oddresult == 1)
                        {
                            Console.WriteLine("Liverpool won the game! Well done, potencional reward ({0}) has been add to your balance!", Pwin);
                            int successWin = Convert.ToInt32(Pwin);
                            balance = successWin + balance;
                            Console.WriteLine("Your actual casino balance: {0}", balance);
                            Console.ReadLine();
                        }else if(oddresult == 2)
                        {
                            Console.WriteLine("Unfortunately for you, Real Madrid won the game! Maybe next time!");
                            Console.ReadLine();
                        }
                        end = false;
                        break;
                    case '2':
                        end = false;
                        break;
                    case '3':
                        end = false;
                        break;
                    case '4':
                        end = false;
                        break;
                    case '5':
                        end = false;
                        break;
                    case '6':
                        end = false;
                        break;
                    case '0':
                        end = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("INVALID OPERATION!");
                        end = true;
                        break;
                }
            } while (end == true);
        }
        static double NextDouble(Random rand, double minValue, double maxValue, int decimalPlaces)
        {
            double randNumber = rand.NextDouble() * (maxValue - minValue) + minValue;
            return Convert.ToDouble(randNumber.ToString("f" + decimalPlaces));
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