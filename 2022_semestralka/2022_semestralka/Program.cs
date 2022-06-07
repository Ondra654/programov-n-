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
                Console.SetCursorPosition(50, 2);
                Console.WriteLine("{0}, your actual balance is: {1}",nickname, balance);
                Console.SetCursorPosition(0,4);
                Console.Write("Enter key: ");
                input = Console.ReadKey().KeyChar;
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
            char loadmenu;
            loadmenu = Menu();
        }
        static void Roulette (ref int balance, ref string nickname)
        {
            Console.Clear();
            Console.WriteLine("Welcome, there is roulette table, choose your bet!");
            Console.WriteLine("Your balance is: {0}", balance);
            Console.WriteLine("┏━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┓");
            for (int i = 0; i < 2; i++){
            Console.WriteLine("┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃");
            Console.WriteLine("┃   ┣━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━┫");
            }
            Console.WriteLine("┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃");
            Console.WriteLine("┗━━━╋━━━┻━━━┻━━━┻━━━╋━━━┻━━━┻━━━┻━━━╋━━━┻━━━┻━━━┻━━━╋━━━┛");
            Console.WriteLine("    ┃    1st 12     ┃    2nd 12     ┃    3nd 12     ┃");
            Console.WriteLine("    ┣━━━━━━━┳━━━━━━━╋━━━━━━━┳━━━━━━━╋━━━━━━━┳━━━━━━━┫");
            Console.WriteLine("    ┃  1-18 ┃  EVEN ┃  RED  ┃ BLACK ┃  ODD  ┃ 19-36 ┃");
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
            Console.SetCursorPosition(0, 13);
            Console.Write("Set you bet please: ");
            int checkbalance = balance;
            int Rbet = NumberCheck();
            bool success = true;
            do{
                if (Rbet > balance){
                    Console.WriteLine("bet is higher than your balance!");
                    Console.Write("Set you bet please: ");
                    Rbet = NumberCheck();
                }
                if (Rbet < balance){
                    break;
                }
            } while (success == true);
            balance = balance - Rbet;
            Console.WriteLine("Select one option and enter specific number");
            Console.WriteLine("┃'1' = specific number┃'2' = 1-18┃'3' = 19-36┃'4' = EVEN┃'5' = ODD┃'6' = RED┃'7' = BLACK┃'8' = 1st 12┃'9' = 2nd 12┃'10' = 3rd 12┃");
            Console.Write("Enter one of the options: ");
            string answer = (Console.ReadLine());
            bool answercheck = answer == "1" || answer == "2" || answer == "3" || answer == "4" || answer == "5" || answer == "6" || answer == "7" || answer == "8" || answer == "9" || answer == "10";
            bool success1 = true;
            do{
                if (answer == "1" || answer == "2" || answer == "3" || answer == "4" || answer == "5" || answer == "6" || answer == "7" || answer == "8" || answer == "9" || answer == "10"){
                    break;
                }else if (answercheck == false){
                    Console.WriteLine("Invalid input!");
                    Console.Write("Enter one of the options: ");
                    answer = (Console.ReadLine());
                }
            } while (success1 == true);

            Random gennumber = new Random();
            int number = gennumber.Next(0, 37);
            int color;
            color = 0;
            Console.WriteLine("{0}", number);
            if (number == 3 || number == 9 || number == 12 || number == 18 || number == 21 || number == 27 || number == 30 || number == 36 || number == 5 || number == 14 || number == 23 || number == 32 || number == 1 || number == 7 || number == 16 || number == 25 || number == 28 || number == 34){
                color = 1;//1 = Red
            }else if (number == 6 || number == 15 || number == 24 || number == 33 || number == 2 || number == 8 || number == 11 || number == 17 || number == 20 || number == 26 || number == 29 || number == 35 || number == 4 || number == 10 || number == 13 || number == 19 || number == 22 || number == 31){
                color = 2;//2 = Black
            }
            bool even = number % 2 == 0;
            Console.WriteLine("{0}", color);
            Console.ReadLine();
            if (answer == "1"){
                Console.WriteLine("Enter particular number from roulette table: ");
                int parnumberbet = Convert.ToInt32(Console.ReadLine());
                bool success2 = true;
                do{
                    if ((parnumberbet < 0) && (parnumberbet >= 37)){
                        Console.WriteLine("Invalid input!");
                        Console.WriteLine("Enter particular number from roulette table: ");
                        parnumberbet = Convert.ToInt32(Console.ReadLine());
                    }else if(parnumberbet == number){
                        Console.WriteLine("The number roulette is {0}!", number);
                        Console.WriteLine("Well done! Your guess was right, your reward has been added to your balance!");
                        balance = balance + Rbet + (Rbet * 35);
                        Console.ReadLine();
                    }else{
                        Console.WriteLine("The roulette number is {0}!", number);
                        Console.WriteLine("Your guess was {0}, try your luck next time!", parnumberbet);
                        Console.ReadLine();
                    }
                    break;
                } while (success2 == true);
            }else if (answer == "2"){
                Console.WriteLine("Your bet is on 1-18");
                if ((number > 0) && (number < 19)){
                    Console.WriteLine("The number roulette is {0}!", number);
                    Rouletteanswer(ref balance, ref Rbet);
                }
            }else if (answer == "3"){
                Console.WriteLine("Your bet is on 19-36");
                if ((number > 18) && (number < 37)){
                    Console.WriteLine("The number roulette is {0}!", number);
                    Rouletteanswer(ref balance, ref Rbet);
                }
            }else if (answer == "4"){
                Console.WriteLine("Your bet is on EVEN numbers");
                if (even == true){
                    Console.WriteLine("The number roulette is {0}!", number);
                    Rouletteanswer(ref balance, ref Rbet);
                }
            }else if (answer == "5"){
                if (even == false){
                    Console.WriteLine("The number roulette is {0}!", number);
                    Rouletteanswer(ref balance, ref Rbet);
                }
            }else if (answer == "6"){
                if (color == 1){
                    Console.WriteLine("The number roulette is {0}!", number);
                    Rouletteanswer(ref balance, ref Rbet);
                }
            }else if (answer == "7"){
                if (color == 2){
                    Console.WriteLine("The number roulette is {0}!", number);
                    Rouletteanswer(ref balance, ref Rbet);
                }
            }else if (answer == "8"){
                if ((number < 13) && (number > 0)){
                    Console.WriteLine("The number roulette is {0}!", number);
                    Rouletteanswer(ref balance, ref Rbet);
                }
            }else if (answer == "9"){
                if ((number < 25) && (number > 12)){
                    Console.WriteLine("The number roulette is {0}!", number);
                    Rouletteanswer(ref balance, ref Rbet);
                }
            }else if (answer == "10"){
                if ((number < 37) && (number > 24)){
                    Console.WriteLine("The number roulette is {0}!", number);
                    Rouletteanswer(ref balance, ref Rbet);
                }
            }
            if (balance < checkbalance){
                Console.WriteLine("The roulette number is {0}! Try your luck next time!", number);
                Console.ReadLine();
            }
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
            double odd1 = NextDouble(rand, 2.07, 3.13, 2);
            rand = new Random();
            double odd2 = NextDouble(rand, 1.00, 1.90, 2);
            double odd3 = NextDouble(rand, 1.05, 1.28, 2);
            rand = new Random();
            double odd4 = NextDouble(rand, 2.10, 3.20, 2);
            double odd5 = NextDouble(rand, 2.73, 4.55, 2);
            rand = new Random();
            double odd6 = NextDouble(rand, 1.02, 1.10, 2);
            rand = new Random();
            double oddresult = rand.Next(1,5);
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("┃      Champions league final:      ┃      Tennis match:        ┃               F1 Monaco race:               ┃");
            Console.WriteLine("     ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("┃      Liverpool x Real Madrid      ┃    Federer x Djokovic     ┃   Verstappen(Redbull) x Leclerc(Ferrari)    ┃");

            Console.SetCursorPosition(5, 6);
            Console.WriteLine("           {0}  ┃  {1}                   {2}  ┃  {3}                          {4}  ┃  {5}", odd1,odd2,odd3,odd4,odd5,odd6);
            Console.WriteLine("Your balance is: {0}", balance);
            Console.Write("First of all enter your bet value please: ");
            int ODDbet = Convert.ToInt32(NumberCheck());
            bool success = true;
            do{
                if (ODDbet > balance){
                    Console.WriteLine("bet is higher than your balance!");
                    Console.Write("Set you bet please: ");
                    ODDbet = NumberCheck();
                }
                if (ODDbet < balance){
                    break;
                }
            } while (success == true);
            balance = balance - ODDbet;
            bool end = true;
            do{
                Console.WriteLine("Enter '1' and bet on Liverpool win");
                Console.WriteLine("Enter '2' and bet on Real Madrid win");
                Console.WriteLine("Enter '3' and bet on Federer win");
                Console.WriteLine("Enter '4' and bet on Djokovic win");
                Console.WriteLine("Enter '5' and bet on Verstappen race win");
                Console.WriteLine("Enter '6' and bet on Leclerc race win");
                Console.Write("Select odd if you want to bet, or enter '0' to leave odds: ");
                char answer = Console.ReadKey().KeyChar;
                switch (answer){
                    case '1':
                        double Pwin = ODDbet * odd1;
                        Console.Clear();
                        Console.WriteLine("Bet {0} on Liverpool win - Potencional win: {1}", ODDbet, Pwin);
                        if (oddresult < 2){
                            Console.WriteLine("Liverpool won the game! Well done, potencional reward ({0}) has been added to your balance!", Pwin);
                            int successWin = Convert.ToInt32(Pwin);
                            balance = successWin + balance + ODDbet;
                            Console.WriteLine("Your actual casino balance: {0}", balance);
                            Console.ReadLine();
                        }else if(oddresult > 2){
                            Console.WriteLine("Unfortunately for you, Real Madrid won the game! Maybe next time!");
                            Console.ReadLine();
                        }
                        end = false;
                        break;
                    case '2':
                        Pwin = ODDbet * odd2;
                        Console.Clear();
                        Console.WriteLine("Bet {0} on Real Madrid win - Potencional win: {1}", ODDbet, Pwin);
                        if (oddresult > 2){
                            Console.WriteLine("Real Madrid won the game! Well done, potencional reward ({0}) has been added to your balance!", Pwin);
                            int successWin = Convert.ToInt32(Pwin);
                            balance = successWin + balance + ODDbet;
                            Console.WriteLine("Your actual casino balance: {0}", balance);
                            Console.ReadLine();
                        }
                        else if (oddresult < 2){
                            Console.WriteLine("Unfortunately for you, Liverpool won the game! Maybe next time!");
                            Console.ReadLine();
                        }
                        end = false;
                        break;
                    case '3':
                        Pwin = ODDbet * odd3;
                        Console.Clear();
                        Console.WriteLine("Bet {0} on Federer win - Potencional win: {1}", ODDbet, Pwin);
                        if (oddresult > 2){
                            Console.WriteLine("Federer won the game! Well done, potencional reward ({0}) has been added to your balance!", Pwin);
                            int successWin = Convert.ToInt32(Pwin);
                            balance = successWin + balance + ODDbet;
                            Console.WriteLine("Your actual casino balance: {0}", balance);
                            Console.ReadLine();
                        }
                        else if (oddresult < 2){
                            Console.WriteLine("Unfortunately for you, Djokovic won the game! Maybe next time!");
                            Console.ReadLine();
                        }
                        end = false;
                        break;
                    case '4':
                        Pwin = ODDbet * odd4;
                        Console.Clear();
                        Console.WriteLine("Bet {0} on Djokovic win - Potencional win: {1}", ODDbet, Pwin);
                        if (oddresult < 2){
                            Console.WriteLine("Djokovic won the match! Well done, potencional reward ({0}) has been added to your balance!", Pwin);
                            int successWin = Convert.ToInt32(Pwin);
                            balance = successWin + balance + ODDbet;
                            Console.WriteLine("Your actual casino balance: {0}", balance);
                            Console.ReadLine();
                        }
                        else if (oddresult > 2){
                            Console.WriteLine("Unfortunately for you, Federer won the match! Maybe next time!");
                            Console.ReadLine();
                        }
                        end = false;
                        break;
                    case '5':
                        Pwin = ODDbet * odd5;
                        Console.Clear();
                        Console.WriteLine("Bet {0} on Verstappen win - Potencional win: {1}", ODDbet, Pwin);
                        if (oddresult < 2){
                            Console.WriteLine("Verstappen won the race! Well done, potencional reward ({0}) has been added to your balance!", Pwin);
                            int successWin = Convert.ToInt32(Pwin);
                            balance = successWin + balance + ODDbet;
                            Console.WriteLine("Your actual casino balance: {0}", balance);
                            Console.ReadLine();
                        }
                        else if (oddresult > 2){
                            Console.WriteLine("Unfortunately for you, Leclerc won the race! Maybe next time!");
                            Console.ReadLine();
                        }
                        end = false;
                        break;
                    case '6':
                        Pwin = ODDbet * odd6;
                        Console.Clear();
                        Console.WriteLine("Bet {0} on Leclerc win - Potencional win: {1}", ODDbet, Pwin);
                        if (oddresult > 2){
                            Console.WriteLine("Leclerc won the race! Well done, potencional reward ({0}) has been added to your balance!", Pwin);
                            int successWin = Convert.ToInt32(Pwin);
                            balance = successWin + balance + ODDbet;
                            Console.WriteLine("Your actual casino balance: {0}", balance);
                            Console.ReadLine();
                        }
                        else if (oddresult < 2){
                            Console.WriteLine("Unfortunately for you, Verstappen won the race! Maybe next time!");
                            Console.ReadLine();
                        }
                        end = false;
                        break;
                    case '0':
                        balance = balance + ODDbet;
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
        static void Rouletteanswer(ref int balance, ref int Rbet)
        {
            Console.WriteLine("Well done! Your guess was right, your reward has been added to your balance!");
            balance = balance + Rbet + (Rbet * 2);
            Console.ReadLine();
        }
    }
}