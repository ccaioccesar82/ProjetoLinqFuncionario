using System.Linq;
using System.Globalization;
using System.IO;

namespace ProjetoLinqFuncionario.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }


        public Employee() { }

        public Employee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

        
    }
}
