using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class User : Person
    {
        private Guid _id;
        public string Username { get; set; }

        public User(string username, string firstName, string lastName, Gender gender, DateTime birthDate) : base(firstName, lastName, gender, birthDate)
        {
            this._id = Guid.NewGuid();
        }

        public User()
        {
        }

        public override string ToString()
        {
            return $"{Username} {FirstName} {LastName} {Gender} {BirthDate}";
        }
    }
}

