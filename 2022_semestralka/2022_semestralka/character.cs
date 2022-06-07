using System;
using System.Collections.Generic;
using System.Text;

namespace _2022_semestralka
{
    class Character
    {
        /*string[] firstnpc = {"Tyler", "Mike", "Winton", "Brian", "Rowan", "Russell", "Derek", "Harry", "Spencer", "Pedro", "Jamie", "Tyler" };
            Random randomName = new Random();
            string NPCname = firstnpc[randomName.Next(firstnpc.Length)];

            Random randombudget = new Random();
            int NPCbalance = randombudget.Next(5000, 10000);

            Character NPC = new Character(NPCname,NPCbalance);
            
            Console.WriteLine("NPC name and balance: {0} - {1}", NPCname, NPCbalance);*/


/*bool success = true;
                            Console.Clear();
                            Console.WriteLine("Odds are: Liverpool: {0}  ┃  Real Madrid: {1}", odd1, odd2);
                            Console.Write("Enter your bet please:");
                            int Fbet = Convert.ToInt32(NumberCheck());
                            do
                            {
                                if (Fbet > balance)
                                {
                                    Console.WriteLine("bet is higher than your balance!");
                                    Console.Write("Set you bet please: ");
                                    Fbet = NumberCheck();
                                }
                                if (Fbet < balance)
                                {
                                    break;
                                }
                            } while (success == true);
                            Console.Write("Select team: '1' for Liverpool or '2' on Real Madrid: ");
                            char Fanswer = Console.ReadKey().KeyChar;
                            switch (Fanswer)
                            {
                                case '1':
                                    double Pwin = Fbet * odd1;
                                    Console.Clear();
                                    Console.WriteLine("Bet on Liverpool win - Potencional win: {0}", Pwin);
                                    Console.ReadLine();
                                    break;
                                case '2':
                                    double Pwin2 = Fbet * odd2;
                                    Console.Clear();
                                    Console.WriteLine("Bet on Real Madrid win - Potencional win: {0}", Pwin2);
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("Invalid input");
                                    endY = false;
                                    break;
                            }*/





private string name;

private int balance;

public string Name
{
    get
    {
        return name;
    }
}
public int Balance
{
    get
    {
        return balance;
    }
}
public Character (string name, int balance)
{
    this.name = name;
    this.balance = balance;

    Reset();
}
public void Reset()
{
    balance = 0;
}
}
}
