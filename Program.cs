using System;
using System.Globalization;
using ProjetoLinqFuncionario.Entities;
using ProjetoLinqFuncionario.Services;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            EmployeeService employeeService = new EmployeeService();


            employeeService.LeArquivo(path, list);
            employeeService.BuscaEmail(salary, list);
            employeeService.SumEmployeeSalary(list);
        }
    }
}