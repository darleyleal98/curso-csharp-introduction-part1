using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable

namespace CursoCSharpParte3
{
    public class Employee
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private double Salary { get; set; }
        private static int count = 1;

        public Employee(int id, string name, double salary) 
        { 
            Id = id;
            Name = name;
            Salary = salary;
        }
        public Employee() { }

        public void IncreaseSalary(double percentage)
        {
            Salary += (Salary * (percentage / 100));
        }
        public override string ToString()
        {
            return $"Employee {count}:\n" +
                   $"Id: {Id}\n" +
                   $"Name: {Name}\n" +
                   $"Salary: {Salary:c}\n"; 
        }
        public void EmployeeTest() // Método para teste será chamado da Main()
        {
            List<Employee> funcionarios = new List<Employee>();

            try
            {
                int quantidadeFuncionarios = int.Parse(Console.ReadLine());

                for (int funcionario = 0; funcionario < quantidadeFuncionarios; funcionario++)
                {
                    Console.WriteLine("Digite o ID:");
                    int idFuncionario = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o Nome:");
                    string nomeFuncionario = Console.ReadLine();

                    Console.WriteLine("Digite o salário:");
                    double salarioFuncionario = double.Parse(Console.ReadLine());

                    foreach (var employee in funcionarios)
                    {
                        if (employee.Id.Equals(idFuncionario))
                        {
                            throw new Exception("ID em uso, tente novamente!");
                        }
                        else
                        {
                            funcionarios.Add(new Employee(idFuncionario, nomeFuncionario, salarioFuncionario));
                        }
                    }
                    Console.WriteLine(funcionarios.ToString());
                    count++;
                }
                Console.WriteLine("Digite o ID do funcionário que receberá o aumento:");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a porcentagem de aumento do salário, ex: 10.0");
                double porcentagemAumentoSalario = double.Parse(Console.ReadLine());

                foreach (Employee funcionario in funcionarios)
                {
                    if (funcionario.Id.Equals(id))
                    {
                        funcionario.IncreaseSalary(porcentagemAumentoSalario);
                    }
                    else
                    {
                        Console.WriteLine("Este Id não existe!");
                    }

                    Console.WriteLine(funcionario.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
