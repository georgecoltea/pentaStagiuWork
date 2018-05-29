using System;
using System.Collections.Generic;

namespace ChatApp
{
    public class User
	{
		private string firstName;
		private string lastName;
		private string email;
		private string password;
        
		public string FirstName { get;  set; }

		public string LastName { get;  set; }
        
		public string Email { get;  set; }

		public string Password { get; set; }

		public User(){}

		public User(string firstName, string lastName, string email, string password)
		{
            this.FirstName = firstName;
            this.LastName = lastName;
			this.Email = email;
			this.Password = password;
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

			Console.Write("Enter a password: ");
			string password = Console.ReadLine();

			User user = new User(firstName, lastName, email, password);

			Console.WriteLine();
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
        
		public Post(){}

		public Post(string author, string message, DateTime date)
        {
			this.Author = author;
			this.Message = message;
			this.Date = date;
            
        }

		public static void CreatePost()
        {
			Console.Write("Enter you name: ");
			string postAuthor = Console.ReadLine();

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