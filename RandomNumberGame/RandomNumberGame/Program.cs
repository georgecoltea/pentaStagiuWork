using System;

namespace RandomNumberGame
{
	class Program
	{
		static void Main(string[] args)
		{
			int randomNumber;
			string userInputLine;

			Random random = new Random();
			randomNumber = random.Next(0, 101);

			int userNumber;

			do
			{

				Console.WriteLine("Please enter a number");
				userInputLine = Console.ReadLine();
				userNumber = int.Parse(userInputLine);

				if (userNumber > randomNumber)
				{
					Console.WriteLine("The entered number is too big");
					continue;
				}
				else
					if (userNumber < randomNumber)
				{
					Console.WriteLine("The entered number is too small");
					continue;
				}

				Console.WriteLine("Well done! You guessed the number");


			} while (userNumber != randomNumber);
		}
	}
}

