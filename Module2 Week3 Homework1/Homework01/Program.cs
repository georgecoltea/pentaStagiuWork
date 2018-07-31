using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

using static Repository.JsonHelper;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = ExtractJson();

            var startDate = new DateTime(1985, 1, 1, 0, 0, 0);
            var endDate = new DateTime(1995, 12, 31, 23, 59, 59);

            var result = persons
                .Where(person => person.BirthDate > startDate)
                .Where(person => person.BirthDate < endDate)
                .Select(person => $"{person.FirstName} {person.LastName}")
                .ToDictionary(person => person, person => person.Count(c => "aeiou".Contains(Char.ToLower(c))))
                .OrderBy(person => person.Value)
                .Select(person => person.Key)
                .ToList();

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
