using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Илья", "Романов", "Александрович", new DateTime(1983, 09, 24), 5, "электрик");
            Console.WriteLine("{0}: {1} {2} {3} {4} лет", employee.Position, employee.LastName, employee.FirstName,
                employee.MiddleName, employee.Age);
            Console.ReadKey();
        }
    }
}
