using System;
using System.Collections.Generic;

namespace ChatApp
{
    public class User
    {
		private int id;
		private string firstName;
		private string lastName;
		private string email;
		private string password;

		public int Id { get; set; }
        
		public string FirstName { get;  set; }

		public string LastName { get;  set; }
        
		public string Email { get;  set; }

		public string Password { get; set; }

		public User(){}

		public User(int id, string firstName, string lastName, string email, string password)
		{
			this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
			this.Email = email;
			this.Password = password;
		}
	}

	public class Post
    {
		private int id;
		private User author;
		private string message;
		private DateTime date;

		public int Id { get; set; }
		public User Author { get; set; }
		public string Message { get; set; }
		public DateTime Date { get; set; }

		public Post(){}

		public Post(int id, User author, string message, DateTime date)
        {
            this.Id = id;
			this.Author = author;
			this.Message = message;
			this.Date = date;
            
        }
    }

	public class Board
    {
		private List<Post> posts;

		public List<Post> Posts { get; set; }

		public Board(){}
    }
    
}