using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee : User
    {
        public Employee(
            string fistName, string lastName, string middleName, DateTime dateOfBirth, int experience, string position)
            : base(fistName, lastName, middleName, dateOfBirth)
        {
            Experience = experience;
            Position = position;
        }

        public string Position { get; protected set; }

        public int Experience { get; protected set; }
    }
}
