using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class User
    {
        public User(string firstName, string lastName, string middleName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            DateOfBirth = dateOfBirth;
        }

        public string FirstName { get; protected set; }

        public string LastName { get; protected set; }

        public string MiddleName { get; protected set; }

        public DateTime DateOfBirth { get; protected set; }

        public int Age
        { 
            get
            {
                return DateTime.Today.Subtract(DateOfBirth).Days / 365;
            }
        }
    }
}
