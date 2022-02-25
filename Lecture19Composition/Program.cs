 using System;


namespace Lecture19Composition
{
	class Program
	{
		static void Main(string[] args)
		{
			Random randomName = new Random();

			string[] firstnpc = {"Tyler", "Mike", "Winton", "Brian", "Rowan", "Russell", "Derek","Harry", "Spencer", "Pedro", "Jamie", "Tyler"};
			string[] secondnpc = {"Harriet", "Lillian", "Sybil", "Andrea", "Chloe"};
			string[] thirdnpc = {"Edward", "Freddie", "Trey", "Thomas", "Alfie", "Logan"};

			string FirstName = firstnpc[randomName.Next(firstnpc.Length)];
			string SecondName = secondnpc[randomName.Next(secondnpc.Length)];
			string ThirdName = thirdnpc[randomName.Next(thirdnpc.Length)];

			int firstlives;
			int secondlives;

			bool successedit = true;

			do
			{
				Random randlives1 = new Random();
				firstlives = randlives1.Next(6, 26);

				Random randlives2 = new Random();
				secondlives = randlives1.Next(6, 26);

				if (firstlives < secondlives)
                {
					break;
				}
			} while (successedit == true);

			Random randlives3 = new Random();
			int thirdlives = randlives3.Next(firstlives, secondlives);

			Random random = new Random();

			Character one = new Character(new AI(random), FirstName, firstlives, 7, 4, 0);
			Character two = new Character(new AI(random), SecondName, secondlives, 8, 5, 0);
			Character pet = new Character(new AI(random), "PET", 10, 5, 4, 0);
			Character three = new Character(new Player(Console.In, Console.Out), ThirdName, thirdlives, 4, 4, 0);

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
