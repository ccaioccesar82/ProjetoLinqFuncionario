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
            if(name.GetType() != typeof(string) || email.GetType() != typeof(string) || salary.GetType() != typeof(double))
            {

                throw new ArgumentException("Tipo de argumentos enviados incompatíveis com o esperado");
            }

            Name = name;
            Email = email;
            Salary = salary;
        }

        
    }
}
