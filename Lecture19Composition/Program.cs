 using System;


namespace Lecture19Composition
{
	class Program
	{
		static void Main(string[] args)
		{
			Random randomName = new Random();

			string[] firstnpc = {"Tyler", "Mike", "Winton", "Brian", "Rowan", "Russell", "Derek"};
			string[] secondnpc = {"Harriet", "Lillian", "Sybil", "Andrea", "Chloe"};
			string[] thirdnpc = {"Edward", "Freddie", "Trey", "Thomas", "Alfie", "Logan"};

			string FirstName = firstnpc[randomName.Next(firstnpc.Length)];
			string SecondName = secondnpc[randomName.Next(secondnpc.Length)];
			string ThirdName = thirdnpc[randomName.Next(thirdnpc.Length)];

			Random random = new Random();

			Character one = new Character(new AI(random), FirstName, 15, 6, 4);
			Character two = new Character(new AI(random), SecondName, 10, 7, 5);
			Character three = new Character(new Player(Console.In, Console.Out), ThirdName, 20, 4, 4);

			Game game = new Game(one, two, new Die(random, 6));
			game.Run(Console.Out);
			Console.WriteLine();

			Game game2 = new Game(one, three, new Die(random, 6));
			game2.Run(Console.Out);
			Console.WriteLine();

			Console.WriteLine("Press any key to quit...");
			Console.ReadKey();
		}
	}
}
