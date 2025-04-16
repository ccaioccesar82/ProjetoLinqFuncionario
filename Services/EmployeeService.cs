using System;
using System.Globalization;
using System.Linq;
using ProjetoLinqFuncionario.Entities;

namespace ProjetoLinqFuncionario.Services
{
    internal class EmployeeService
    {


        public void LeArquivo(string path, List<Employee> list) //Lê um arquivo .txt com nome, email e salário de funcionários
        {
            StreamReader sr = null;

            try
            {
                using (sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        string email = line[1];
                        double salary = double.Parse(line[2], CultureInfo.InvariantCulture);

                        list.Add(new Employee { Name = name, Email = email, Salary = salary });
                    }

                }
            }
            catch (IOException e)
            {

                Console.WriteLine("An error ocurred: ");
                Console.WriteLine(e.Message);
            }
        }

        public void BuscaEmail(double salary, List<Employee> list)
        {//Retorna lista de emails de funcionários que possuem salário maior ao parâmetro passado

            var result = list.Where(f => f.Salary > salary).OrderBy(f => f.Email).Select(f => f.Email);

            Console.WriteLine($"Email of people whose salary is more than {salary}: ");
            foreach (string email in result) {          
            Console.WriteLine(email);
        }

        }


        public void SumEmployeeSalary(List<Employee> list)
        { //Retorna a soma total de todos os funcionários que possuem a inicial 'M'

            var result = list.Where(f => f.Name[0] == 'M').Select(f => f.Salary).Sum();
            Console.Write("Sum of salary of people whose name starts with 'M' : ");
            Console.WriteLine(result);
        }
    }
}
