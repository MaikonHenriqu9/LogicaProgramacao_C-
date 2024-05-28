/*
    Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário 
    médio dos funcionários
*/

using System;
using System.Globalization;

namespace Exercicio {
    class Program {
        static void Main(string[] args){

            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("================= Salário Médio =================");
            Console.Write("Informe o nome do primeiro funcionário: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Informe o seu salário: R$");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nInforme o nome do segundo funcionário: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Informe o seu salário: R$");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario = (funcionario1.Salario + funcionario2.Salario) / 2.0;

            Console.WriteLine($"\nMédia salarial: R${mediaSalario.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}