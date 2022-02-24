using System;
using System.IO;


namespace Lecture19Composition
{
	class Character
	{
		public const string TURN_CHOICE_ATTACK = "attack";
		public const string TURN_CHOICE_WAIT = "wait";

		private Controller controller;

		private string name;

		private int hp;
		private int maxHp;

		private int attack;
		private int defense;

		private int accuracy;

		public string Name
		{
			get {
				return name;
			}
		}


		public int Hp
		{
			get {
				return hp;
			}
		}


		public int MaxHp
		{
			get {
				return maxHp;
			}
		}


		public bool Alive
		{
			get {
				return hp > 0;
			}
		}


		public int Attack
		{
			get {
				return attack;
			}
		}


		public int Defense
		{
			get {
				return defense;
			}
		}

		public Character(Controller controller, string name, int maxHp, int attack, int defense, int accuracy)
		{
			this.controller = controller;
			this.name = name;
			this.maxHp = maxHp;
			this.attack = attack;
			this.defense = defense;
			this.accuracy = accuracy;

			Reset();
		}

		int healnpc = 0;
		public void TakeTurn(TextWriter output, Character enemy, Die die)
		{
			string action = controller.ChooseAction(this, enemy);

			switch (action) {
				case TURN_CHOICE_ATTACK:
					AttackEnemy(output, enemy, die);
					break;

				case TURN_CHOICE_WAIT:

					Random randheal = new Random();
					healnpc = randheal.Next(3, 5);
					hp = hp + healnpc;
					if (hp > maxHp)
                    {
						hp = maxHp;
                    }
					Wait(output, die);
					break;

				default:
					output.WriteLine("{0} does nothing...", name);
					break;
			}
		}

		public void Reset()
		{
			hp = maxHp;
		}

		int mainaccuracy;
		private void AttackEnemy(TextWriter output, Character enemy, Die die)
		{
			int attackRoll;
			Random randaccuracy1 = new Random();
			mainaccuracy = randaccuracy1.Next(1, 6);

			if (mainaccuracy < 2)
            {
				attackRoll = 0;
				Console.WriteLine("{0}'s accuracy is low this time and miss!", name);
				Console.WriteLine("{0} takes no damage!", enemy.Name);

				AdvantageAttack(output, attackRoll, enemy, die);

			}
			else
            {
			output.WriteLine("{0} attacks {1}!", name, enemy.Name);
			attackRoll = attack + die.Roll();
			enemy.ReceiveAttack(output, attackRoll, die);
            }
		}


		private void AdvantageAttack(TextWriter output, int attackRoll, Character enemy, Die die)
        {
			int defenceRoll = defense + die.Roll();
			int damage = attackRoll - defenceRoll;

			Random randadvantage = new Random();
			int randdmg = randadvantage.Next(6, 9);
			int advantagedmg = randdmg - defenceRoll;

			if (advantagedmg > 0)
			{
				hp -= advantagedmg;
				output.WriteLine("{0} takes {1} damage!", enemy.Name, advantagedmg);
				Console.WriteLine("success dmg > 0");
			}
			else
			{
				output.WriteLine("{0} takes no damage!", enemy.Name);
				Console.WriteLine("dmg < 0"); 
			}

		}
		private void ReceiveAttack(TextWriter output, int attackRoll, Die die)
		{
			int defenseRoll = defense + die.Roll();
			int damage = attackRoll - defenseRoll;
			
			if (damage > 0) {
				hp -= damage;
				output.WriteLine("{0} takes {1} damage!", name, damage);
			} else {
				output.WriteLine("{0} takes no damage!", name);
			}
		}


		private void Wait(TextWriter output, Die die)
		{
			output.WriteLine("{0} waits, heal and rolls a die...", name);
			output.WriteLine("They rolled a {0}!", die.Roll());
		}
	}
}
