using System;
using System.Collections.Generic;

namespace ChatApp
{
    class Program
    {
        static void Main(string[] args)
        {
			User george = new User
			{
				FirstName = "George",
				LastName = "Coltea",
                Email = "george@gmail.com",
                Password = "parola"

            };

			Post post1 = new Post
			{
				Author = "George Coltea",
				Message = "Multe clase",
				Date = new DateTime(2018, 4, 16)
			};
            
			Post.AddToBoard(post1);

			//start of actual program
            
			while (true)
			{

				Console.WriteLine("1. Create new account");
				Console.WriteLine("2. Post a message");
				Console.WriteLine("3. Display posts");
				Console.WriteLine("4. Exit");

				Console.WriteLine();
				Console.Write("Please choose from the provided options ");
				string menuOption = Console.ReadLine();

				switch (menuOption)
				{
					case "1":
						User.CreateAccount();
						break;
					case "2":
						Post.CreatePost();
						break;
					case "3":
						Post.DisplayBoard();
						break;
					case "4":
						Console.WriteLine("Thank you for using our application");
						return;
				}
			}
            

				

        }
    }
}
