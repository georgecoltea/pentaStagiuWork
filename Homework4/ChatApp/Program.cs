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
				Username = "georgec0022",
                Password = "parola"

            };

			User.AddToUserList(george);
            

			Post post1 = new Post
			{
				Author = "georgec0022",
				Message = "Multe clase",
				Date = new DateTime(2018, 4, 16)
			};
            
			Post.AddToBoard(post1);
            
			//start of actual program
            
			while (true)
			{
				if(!User.isLogged)
				{
					Console.WriteLine("1. Login");
					Console.WriteLine("2. Create new account");
					Console.WriteLine("3. Exit");

					Console.WriteLine();
                    Console.Write("Please choose from the provided options ");
                    string loginMenuOption = Console.ReadLine();

					switch (loginMenuOption)
                    {
                        case "1":
                            User.Login();
							User.isLogged = true;
							break;
                        case "2":
							User.CreateAccount();
							User.isLogged = true;
                            break;
                        case "3":
                            Console.WriteLine("Thank you for using our application");
                            return;
                    }

				}
				else
				{
                    Console.WriteLine("1. Post a message");
					Console.WriteLine("2. Display posts");
                    Console.WriteLine("3. Exit");

                    Console.WriteLine();
                    Console.Write("Please choose from the provided options ");
                    string menuOption = Console.ReadLine();

                    switch (menuOption)
					{
                        case "1":
                            Post.CreatePost();
                            break;
                        case "2":
                            Post.DisplayBoard();
                            break;
                        case "3":
                            Console.WriteLine("Thank you for using our application");
                            return;
                    }
				}
                    

			}
            

				

        }
    }
}
