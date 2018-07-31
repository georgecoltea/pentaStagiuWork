using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Repository.JsonHelper;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = ExtractJson();

            var result = persons
                .Select( p => new User()
                {
                    Username = $"{p.FirstName}{p.LastName}{p.BirthDate.ToString("yy")}",
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Gender = p.Gender,
                    BirthDate = p.BirthDate
                })
                .ToList();

            foreach (User user in result)
            {
                Console.WriteLine(user);
            }
            Console.ReadKey();
        }
    }
}
