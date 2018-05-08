using System;

namespace RandomNumberGame
{
	class Program
	{
		static void Main(string[] args)
		{
			int randomNumber, userNumber;
			string str;

			Random random = new Random();
			randomNumber = random.Next(0, 101);

			bool ok = false;

			while(!ok){

				Console.WriteLine("Please enter a number");
				str = Console.ReadLine();
				userNumber = int.Parse(str);

				if(userNumber > randomNumber)
				{
					Console.WriteLine("The entered number is too big");
					continue;
				}
				else
					if(userNumber < randomNumber)
				    {
					    Console.WriteLine("The entered number is too small");
					    continue;
				    }
               
				Console.WriteLine("Well done! You guessed the number");
				ok = true;
				

			}
		}
	}
}

