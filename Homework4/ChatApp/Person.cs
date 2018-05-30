using System;
using System.Collections.Generic;

namespace ChatApp
{
	public class User
	{
		public static List<User> usernameList = new List<User>();
		public static bool isLogged = false;

		private string firstName;
		private string lastName;
		private string email;
		private string username;
		private string password;


		public string FirstName { get { return this.firstName; } set { firstName = value; } }

		public string LastName { get { return lastName; } set { lastName = value; } }

		public string Email { get { return email; } set { email = value; } }

		public string Username { get { return username; } set { username = value; } }

		public string Password { get { return password; } set { password = value; } }

		public User() { }

		public User(string firstName, string lastName, string email, string username, string password)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Email = email;
			this.Username = username;
			this.Password = password;
		}


		public static void Login()
		{

			while (isLogged == false)
			{
				Console.WriteLine("Enter your usename ");
				string logInUsername = Console.ReadLine();

				Console.WriteLine("Enter your password ");
				string logInPassword = Console.ReadLine();

				int index = 0;

				foreach (object user in usernameList)
				{


					string addedLoginUsername = User.usernameList[index].Username;
					string addedLoginPassword = User.usernameList[index].Password;
					if (logInUsername == addedLoginUsername && logInPassword == addedLoginPassword)
					{
						isLogged = true;

						Console.WriteLine("You logged in succesfully!");
						Console.WriteLine();
					}
					else
					{
						if (logInUsername != addedLoginUsername)
						{
							Console.WriteLine("Incorrect username!");
							Console.WriteLine();
						}
						else
						{
							int numberOfTries = 3;

							while (numberOfTries > 0)
							{
								Console.WriteLine("Enter your password ");
								logInPassword = Console.ReadLine();

								if (logInPassword == addedLoginPassword)
								{
									isLogged = true;
									numberOfTries = 0;
								}
								else
								{
									numberOfTries--;
								}

								if (numberOfTries == 0)
								{
									Console.WriteLine("You have been logged out...");
									Console.WriteLine();
								}

							}
						}

					}

					index++;
				}
			}

		}

		public static void CreateAccount()
		{
			Console.WriteLine();


			Console.Write("Enter your first name: ");
			string firstName = Console.ReadLine();

			Console.Write("Enter your last name: ");
			string lastName = Console.ReadLine();

			Console.Write("Enter your email: ");
			string email = Console.ReadLine();

			Console.Write("Enter a username ");
			string username = Console.ReadLine();

			Console.Write("Enter a password: ");
			string password = Console.ReadLine();

			User user = new User(firstName, lastName, email, username, password);

			AddToUserList(user);

			Console.WriteLine();
		}

		public static void AddToUserList(User user)
		{
			usernameList.Add(user);
		}

		public static string GetLoggedInUser()
		{
			bool validUser = false;

			string logInUsername = "";

			while (validUser == false)
			{
				int index = 0;
				Console.WriteLine("Enter your username: ");
                logInUsername = Console.ReadLine();

				foreach (object user in usernameList)
                {

                    string addedLoginUsername = User.usernameList[index].Username;
                    if (logInUsername == addedLoginUsername)
                    {
						validUser = true;
                        break;
                    }

                    index++;


                }
			}


			return logInUsername;

		}

	}

		public class Post
		{

			static List<object> board = new List<object>();

			private string author;
			private string message;
			private DateTime date;

			public string Author { get; set; }
			public string Message { get; set; }
			public DateTime Date { get; set; }

			public Post() { }

			public Post(string author, string message, DateTime date)
			{
				this.Author = author;
				this.Message = message;
				this.Date = date;

			}

			public static void CreatePost()
			{
				string postAuthor = User.GetLoggedInUser();

				Console.Write("Please enter your post body: ");
				string postMessage = Console.ReadLine();

				Post post = new Post(postAuthor, postMessage, DateTime.Now);
				AddToBoard(post);

				Console.WriteLine();
			}

			public static bool DisplayBoard()
			{
				Console.WriteLine();

				foreach (object post in board)
				{
					Console.WriteLine(post.ToString());
				}

				Console.WriteLine();
				return true;
			}

			public override string ToString()
			{
				return $"{Message} - by {Author} on {Date}";
			}

			public static void AddToBoard(Post post)
			{
				board.Add(post);
			}


		}

	
}