/* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, 
 * o valor que recebe por hora e calcula o salário desse funcionário. 
 * A seguir, mostre o número e o salário do funcionário, com duas casas decimais. */

using System;
using System.Globalization;

namespace Exercicios
{
    class Exercicio04
    {
        static void Main(string[] args)
        {
            int numeroDoFuncionario = 100;
            double horasTrabalhadas, valorHora, salario;

            Console.Write("Digite o número de registro do funcionário: ");
            numeroDoFuncionario = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de horas trabalhadas neste mês: ");
            horasTrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o valor que recebe por horas trabalhadas: ");
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horasTrabalhadas;

            Console.WriteLine($"Número de registro do funcionário: {numeroDoFuncionario}");
            Console.WriteLine($"Horas trabalhadas neste mês: {horasTrabalhadas}");
            Console.WriteLine($"Valor do Salário: R${salario.ToString("f2", CultureInfo.InvariantCulture)}");

            Thread.Sleep(5000);
        }
    }
}