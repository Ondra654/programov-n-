using System.IO;
using System;
using System.Text.RegularExpressions;

namespace _2022_semestralka
{
    class Program
    {
        static char Menu()
        {
            Console.Write("Enter your nickname: ");
            string nickname = Console.ReadLine();
            LettersCheck(ref nickname);
            Console.WriteLine("{0}, welcome in casino!",nickname);
            Console.WriteLine("1 Casino coin = 2 €, our worker can not exchange you more than 500 Casino coins!");
            Console.Write("How many casino coins do you want to exchange? ");
            int coins = Convert.ToInt32(NumberCheck());
            bool success = true;
            do{
                if (coins > 500){
                    Console.WriteLine("Sorry, our worker can exchange maximum amount of 500 Casino coins and also minimum amount of 30 Casino coins");
                    Console.Write("How many casino coins do you want to change? ");
                    coins = NumberCheck();
                }else if (coins < 30){
                    Console.WriteLine("Minimum amount of Casino coins is 30!");
                    Console.Write("How many casino coins do you want to change? ");
                    coins = NumberCheck();
                }else if (coins <= 500){
                    break;
                }
            } while (success == true);
            int balance = coins;
            int exchange = 0;
            char input;
            while (true){
                Console.Clear();
                Console.WriteLine("Press 'r' to play Roulette");
                Console.WriteLine("Press 'b' to play Blackjack");
                Console.WriteLine("Press 'o' to play Odds");
                Console.WriteLine("Press 'h' to open highscore table");
                Console.WriteLine("Press 'l' to leave casino");
                Console.SetCursorPosition(50, 2);
                Console.WriteLine("{0}, your actual coins amount is: {1}",nickname, balance);
                Console.SetCursorPosition(0,5);
                Console.Write("Enter key: ");
                input = Console.ReadKey().KeyChar;
                switch (input){
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
                    case 'h':
                    case 'H':
                        OpenHighscore(ref balance, ref nickname);
                        break;
                    case 'l':
                    case 'L':
                        LeavingCasino(ref balance, ref nickname, ref exchange);
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
            Console.SetWindowSize(150, 30);
            Menu();
        }
        static void Roulette (ref int balance, ref string nickname)
        {
            Console.Clear();
            Console.WriteLine("Welcome, there is roulette table, choose your bet!");
            Console.WriteLine("Your actual coins balance is: {0}", balance);
            Console.WriteLine("┏━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┓");
            for (int i = 0; i < 2; i++){
            Console.WriteLine("┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃row┃");
            Console.WriteLine("┃   ┣━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━┫");
            }
            Console.WriteLine("┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃   ┃row┃");
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
                }else if (Rbet == 0){
                    Console.WriteLine("bet is higher than your balance!");
                    Console.Write("Set you bet please: ");
                    Rbet = NumberCheck();
                }
                if (Rbet <= balance){
                    break;
                }
            } while (success == true);
            balance = balance - Rbet;
            Console.WriteLine("Select one option and enter specific number");
            Console.SetCursorPosition(60, 5);
            Console.WriteLine("┃'1' = specific number┃  '2' = 1-18  ┃ '3' = 19-36  ┃ '4' = EVEN ┃  '5' = ODD  ┃");
            Console.SetCursorPosition(60, 6);
            Console.WriteLine("┃      '6' = RED      ┃  '7' = BLACK ┃ '8' = 1st 12 ┃'9' = 2nd 12┃'10' = 3rd 12┃");
            Console.SetCursorPosition(60, 7);
            Console.WriteLine("┃   '11' = 1st row    ┃'12' = 2nd row┃'13' = 3rd row┃");
            Console.SetCursorPosition(0, 15);
            Console.Write("Enter one of the options: ");
            string answer = (Console.ReadLine());
            bool answercheck = answer == "1" || answer == "2" || answer == "3" || answer == "4" || answer == "5" || answer == "6" || answer == "7" || answer == "8" || answer == "9" || answer == "10" || answer == "11" || answer == "12" || answer == "13";
            bool success1 = true;
            do{
                if (answer == "1" || answer == "2" || answer == "3" || answer == "4" || answer == "5" || answer == "6" || answer == "7" || answer == "8" || answer == "9" || answer == "10" || answer == "11" || answer == "12" || answer == "13")
                {
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
            if (number == 3 || number == 9 || number == 12 || number == 18 || number == 21 || number == 27 || number == 30 || number == 36 || number == 5 || number == 14 || number == 23 || number == 32 || number == 1 || number == 7 || number == 16 || number == 25 || number == 28 || number == 34){
                color = 1;//1 = Red
            }else if (number == 6 || number == 15 || number == 24 || number == 33 || number == 2 || number == 8 || number == 11 || number == 17 || number == 20 || number == 26 || number == 29 || number == 35 || number == 4 || number == 10 || number == 13 || number == 19 || number == 22 || number == 31){
                color = 2;//2 = Black
            }
            bool even = number % 2 == 0;
            bool row1 = number % 3 == 0;
            bool row2 = number == 2 || number == 5 || number == 8 || number == 11 || number == 14 || number == 17 || number == 20 || number == 23 || number == 26 || number == 29 || number == 33 || number == 35;
            bool row3 = number == 1 || number == 4 || number == 7 || number == 10 || number == 13 || number == 16 || number == 19 || number == 22 || number == 25 || number == 28 || number == 31 || number == 34;
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
                        Console.WriteLine("The roulette number is {0}!", number);
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
                    Console.WriteLine("The roulette number is {0}!", number);
                    Rouletteanswer(ref balance, ref Rbet);
                }
            }else if (answer == "3"){
                Console.WriteLine("Your bet is on 19-36");
                if ((number > 18) && (number < 37)){
                    Console.WriteLine("The roulette number is {0}!", number);
                    Rouletteanswer(ref balance, ref Rbet);
                }
            }else if (answer == "4"){
                Console.WriteLine("Your bet is on EVEN numbers");
                if (even == true){
                    Console.WriteLine("The roulette number is {0}!", number);
                    Rouletteanswer(ref balance, ref Rbet);
                }
            }else if (answer == "5"){
                if (even == false){
                    Console.WriteLine("The roulette number is {0}!", number);
                    Rouletteanswer(ref balance, ref Rbet);
                }
            }else if (answer == "6"){
                if (color == 1){
                    Console.WriteLine("The roulette number is {0}!", number);
                    Rouletteanswer(ref balance, ref Rbet);
                }
            }else if (answer == "7"){
                if (color == 2){
                    Console.WriteLine("The roulette number is {0}!", number);
                    Rouletteanswer(ref balance, ref Rbet);
                }
            }else if (answer == "8"){
                if ((number < 13) && (number > 0)){
                    Console.WriteLine("The number roulette is {0}!", number);
                    Rouletteanswer(ref balance, ref Rbet);
                }
            }else if (answer == "9"){
                if ((number < 25) && (number > 12)){
                    Console.WriteLine("The roulette number is {0}!", number);
                    Rouletteanswer(ref balance, ref Rbet);
                }
            }else if (answer == "10"){
                if ((number < 37) && (number > 24)){
                    Console.WriteLine("The roulette number is {0}!", number);
                    Rouletteanswer(ref balance, ref Rbet);
                }
            }else if (answer == "11"){
                if (row1 == true){
                    Console.WriteLine("The roulette number is {0}!", number);
                    Rouletteanswer(ref balance, ref Rbet);
                }
            }else if (answer == "12"){
                if (row2 == true){
                    Console.WriteLine("The roulette number is  {0}!", number);
                    Rouletteanswer(ref balance, ref Rbet);
                }
            }else if (answer == "13"){
                if (row3 == true){
                    Console.WriteLine("The roulette number is {0}!", number);
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
            Console.WriteLine("{0}, welcome on blackjack game! Your actual coins balance is {1}",nickname, balance);
            Console.Write("Set  your bet please: ");
            int Bbet = Convert.ToInt32(NumberCheck());
            bool success = true;
            do{
                if (Bbet > balance){
                    Console.WriteLine("bet is higher than your balance!");
                    Console.Write("Set you bet please: ");
                    Bbet = NumberCheck();
                }else if (Bbet == 0){
                    Console.WriteLine("bet is higher than your balance!");
                    Console.Write("Set you bet please: ");
                    Bbet = NumberCheck();
                }if (Bbet <= balance){
                    break;
                }
            } while (success == true);
            balance = balance - Bbet;
            Console.Clear();
            Console.WriteLine("Croupier is now dealing out the cards");
            int CardValue = 0;
            int gencard = 0;
            GenerateCardValue(ref CardValue, ref gencard);
            int PlayerCardValue1 = CardValue;
            GenerateCardValue(ref CardValue, ref gencard);
            int PlayerCardValue2 = CardValue;
            int PlayerCardValueSum = PlayerCardValue1 + PlayerCardValue2;
            Console.WriteLine("Values of your cards are: {0}  and  {1}, in sum = {2}", PlayerCardValue1, PlayerCardValue2,PlayerCardValueSum);
            GenerateCardValue(ref CardValue, ref gencard);
            int CroupierCardValue1 = CardValue;
            GenerateCardValue(ref CardValue, ref gencard);
            int CroupierCardValue2 = CardValue;
            int CroupierCardValueSum = CroupierCardValue1 + CroupierCardValue2;
            Console.WriteLine("Croupier´s cards are: {0}  and  {1}, in sum = {2}", CroupierCardValue1, CroupierCardValue2,CroupierCardValueSum);
            bool moveend = true;
            do{
                Console.WriteLine("Please select you next move: ");
                Console.WriteLine("Enter '1' to HIT = take another card");
                Console.WriteLine("Enter '2' to STAND = take no more cards");
                Console.WriteLine("Enter '3' to DOUBLE = double your bet and taking one more card");
                Console.WriteLine("Enter '4' to SURRENDER = losing game, but losing only a half of your bet");
                Console.Write("Your answer: ");
                char answer = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (answer){
                    case '1':
                        GenerateCardValue(ref CardValue, ref gencard);
                        int PlayerCartValue3 = CardValue;
                        Console.WriteLine("New card value is {0}", PlayerCartValue3);
                        PlayerCardValueSum = PlayerCardValueSum + PlayerCartValue3;
                        if(PlayerCardValueSum > 21){
                            Console.WriteLine("Card sum ({0}) is higher than 21! Your are trop and you lost the game",PlayerCardValueSum);
                            Console.ReadLine();
                            moveend = false;
                        }else if(PlayerCardValueSum <= 21){
                            Console.WriteLine("New card sum is {0}", PlayerCardValueSum);
                            moveend = true;
                        }
                        break;
                    case '2':
                        Console.WriteLine("Staying...");
                        moveend = false;
                        break;
                    case '3':
                        balance = balance + Bbet;
                        Bbet = Bbet * 2;
                        balance = balance - Bbet;
                        GenerateCardValue(ref CardValue, ref gencard);
                        PlayerCartValue3 = CardValue;
                        Console.WriteLine("New card value is {0}", PlayerCartValue3);
                        PlayerCardValueSum = PlayerCardValueSum + PlayerCartValue3;
                        if (PlayerCardValueSum > 21){
                            Console.WriteLine("Card sum ({0}) is higher than 21! Your are trop and you lost the game", PlayerCardValueSum);
                            Console.ReadLine();
                            moveend = false;
                        }
                        else if (PlayerCardValueSum <= 21){
                            Console.WriteLine("New card sum is {0}", PlayerCardValueSum);
                            moveend = false;
                        }
                        break;
                    case '4':
                        Console.WriteLine("Surrendering...");
                        Bbet = Bbet / 2;
                        balance = balance + Bbet;
                        moveend = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("INVALID OPERATION!");
                        moveend = true;
                        break;
                }
            }while (moveend == true);
            Console.WriteLine("Croupier is selecting his move...");
            if(CroupierCardValueSum < 17){
                Console.WriteLine("Croupier´s card sum is lower than 17, he has to take another");
                GenerateCardValue(ref CardValue, ref gencard);
                int CroupierCardValue3 = CardValue;
                Console.WriteLine("New card value is {0}", CroupierCardValue3);
                CroupierCardValueSum = CroupierCardValueSum + CroupierCardValue3;
                if(CroupierCardValueSum > 21){
                    Console.WriteLine("Croupier´s card sum ({0}) is higher than 21! Croupier is trop and you won the game", CroupierCardValueSum);
                    int Bwin = Bbet * 2;
                    Console.WriteLine("Your reward ({0} coins) has been added to your balance!",Bwin);
                    balance = balance + Bwin + Bbet;
                    Console.ReadLine();
                }else if (CroupierCardValueSum <= 21){
                    Console.WriteLine("New croupier´s card sum is {0}", CroupierCardValueSum);
                }
            }else if (CroupierCardValueSum > 17){
                Console.WriteLine("Croupier´s card sum is higher than 17, he has to stay");
            }
            if (PlayerCardValueSum == CroupierCardValueSum){
                Console.WriteLine("DRAW!");
                Console.WriteLine("Your card sum is {0}", PlayerCardValueSum);
                Console.WriteLine("Croupier´s card sum is {0}", CroupierCardValueSum);
                Console.WriteLine("You would NOT be charged and your bet has been returned to your balance");
            }else if ((PlayerCardValueSum <= 21) && (CroupierCardValueSum <= 21) && (PlayerCardValueSum > CroupierCardValueSum)){
                int Bwin = Bbet * 2;
                Console.WriteLine("Great job! You won the game, your reward ({0} coins) has been added to your balance", Bwin);
                balance = balance + Bwin + Bbet;
            }else if ((PlayerCardValueSum <= 21) && (CroupierCardValueSum <= 21) && (PlayerCardValueSum < CroupierCardValueSum)){
                Console.WriteLine("Croupier won the game, See you next time!");
            }
            Console.ReadLine();
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
            Console.WriteLine("Your actual coins balance is: {0}", balance);
            Console.Write("First of all enter your bet value please: ");
            int ODDbet = Convert.ToInt32(NumberCheck());
            bool success = true;
            do{
                if (ODDbet > balance){
                    Console.WriteLine("bet is higher than your balance!");
                    Console.Write("Set you bet please: ");
                    ODDbet = NumberCheck();
                }else if (ODDbet == 0){
                    Console.WriteLine("bet is higher than your balance!");
                    Console.Write("Set you bet please: ");
                    ODDbet = NumberCheck();
                }if (ODDbet <= balance){
                    break;
                }
            }while (success == true);
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
                        if (oddresult <= 2){
                            Console.WriteLine("Liverpool won the game! Well done, potencional reward ({0} coins) has been added to your balance!", Pwin);
                            int successWin = Convert.ToInt32(Pwin);
                            balance = successWin + balance + ODDbet;
                            Console.WriteLine("Your actual coins balance: {0}", balance);
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
                            Console.WriteLine("Real Madrid won the game! Well done, potencional reward ({0} coins) has been added to your balance!", Pwin);
                            int successWin = Convert.ToInt32(Pwin);
                            balance = successWin + balance + ODDbet;
                            Console.WriteLine("Your actual coins balance: {0}", balance);
                            Console.ReadLine();
                        }
                        else if (oddresult <= 2){
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
                            Console.WriteLine("Federer won the game! Well done, potencional reward ({0} coins) has been added to your balance!", Pwin);
                            int successWin = Convert.ToInt32(Pwin);
                            balance = successWin + balance + ODDbet;
                            Console.WriteLine("Your actual coins balance: {0}", balance);
                            Console.ReadLine();
                        }
                        else if (oddresult <= 2){
                            Console.WriteLine("Unfortunately for you, Djokovic won the game! Maybe next time!");
                            Console.ReadLine();
                        }
                        end = false;
                        break;
                    case '4':
                        Pwin = ODDbet * odd4;
                        Console.Clear();
                        Console.WriteLine("Bet {0} on Djokovic win - Potencional win: {1}", ODDbet, Pwin);
                        if (oddresult <= 2){
                            Console.WriteLine("Djokovic won the match! Well done, potencional reward ({0} coins) has been added to your balance!", Pwin);
                            int successWin = Convert.ToInt32(Pwin);
                            balance = successWin + balance + ODDbet;
                            Console.WriteLine("Your actual coins balance: {0}", balance);
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
                        if (oddresult <= 2){
                            Console.WriteLine("Verstappen won the race! Well done, potencional reward ({0} coins) has been added to your balance!", Pwin);
                            int successWin = Convert.ToInt32(Pwin);
                            balance = successWin + balance + ODDbet;
                            Console.WriteLine("Your actual coins balance: {0}", balance);
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
                            Console.WriteLine("Leclerc won the race! Well done, potencional reward ({0} coins) has been added to your balance!", Pwin);
                            int successWin = Convert.ToInt32(Pwin);
                            balance = successWin + balance + ODDbet;
                            Console.WriteLine("Your actual coins balance: {0}", balance);
                            Console.ReadLine();
                        }
                        else if (oddresult <= 2){
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
        static void SaveHighscore(ref int balance, ref string nickname)
        {
            string path = @"C:\Users\Ondra\source\repos\2022_semestralka\2022_semestralka\bin\Debug\netcoreapp3.1\DataSaver.txt";
            string Cbalance = Convert.ToString(balance);
            string text = " with final balance ";
            string text2 = " Casino coins!";
            string contents = (nickname + text + Cbalance +  text2) + Environment.NewLine;
            File.WriteAllText(path,contents);
        }
        static void OpenHighscore (ref int balance, ref string nickname)
        {
            Console.Clear();
            Console.WriteLine("There is your scoreboard:");
            string data = File.ReadAllText("DataSaver.txt");
            Console.WriteLine("No data yet!");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("{0}", data);
            Console.WriteLine("Enter '0 to continue or '1' for deleting whole scoreboard history");
            Console.Write("Your answer: ");
            char answer = Console.ReadKey().KeyChar;
            switch (answer)
            {
                case '0':
                    Console.WriteLine();
                    Console.Write("Press any key...");
                    Console.ReadLine();
                    break;
                case '1':
                    File.Delete("DataSaver.txt");
                    Console.WriteLine("File has been rewrited and for now is empty");
                    Console.Write("Press any key...");
                    Console.ReadLine();
                    break;
            }
        }
        static void LeavingCasino (ref int balance, ref string nickname, ref int exchange)
        {
            Console.Clear();
            Console.WriteLine("You exchanged your Casino coins and left, there are your results: ");
            exchange = balance * 2;
            Console.WriteLine("{0} with final Casino coins balance: {1}, after exchange: {2}", nickname, balance, exchange);
            Console.WriteLine("Your final score is now saved in scoreboard!");
            SaveHighscore(ref balance, ref nickname);
            Console.Write("Press any key to leave:");
            Console.ReadLine();
            Environment.Exit(1);
        }
        static void LettersCheck(ref string nickname)
        {
            bool success = true;
            do{
            if (Regex.IsMatch(nickname, "^[a-zA-Z]") == false){
                    Console.WriteLine("Nickname must contains only letters!");
                    Console.Write("Enter your nickname: ");
                    nickname = Console.ReadLine();
                }else if (Regex.IsMatch(nickname, "^[a-zA-Z]") == true){
                    break;
                } 
            }while (success == true);
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
            do{
                string input = Console.ReadLine();
                success = int.TryParse(input, out result) && !(nonZero && result == 0);
                if (!success){
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
        static void GenerateCardValue (ref int CardValue, ref int gencard)
        {
            Random gen = new Random();
            gencard = gen.Next(2, 14);
            if (gencard >= 10){
                CardValue = 10;
            }else if (gencard < 10){
                CardValue = gencard;
            }
        }
    }
}