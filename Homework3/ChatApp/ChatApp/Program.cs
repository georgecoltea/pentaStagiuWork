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
				Id = 1,
				FirstName = "George",
				LastName = "Coltea",
                Email = "george@gmail.com",
                Password = "parola"

            };


			Post post1 = new Post
			{
				Id = 1,
				Author = george,
				Message = "Am scris trei noi clase",
				Date = new DateTime(2018, 5, 28)

			};

			Board mainBoard = new Board();
			mainBoard.Posts = new List<Post>();
			mainBoard.Posts.Add(post1);

			Console.WriteLine(post1);
				

        }
    }
}
