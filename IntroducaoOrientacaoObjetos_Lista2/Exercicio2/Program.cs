/*
    Fazer um programa para ler os dados de um funcionário (nome, 
    salário bruto e imposto). Em seguida, mostrar os dados do 
    funcionário (nome e salário líquido). Em seguida, aumentar o salário 
    do funcionário com base em uma porcentagem dada (somente o 
    salário bruto é afetado pela porcentagem) e mostrar novamente os 
    dados do funcionário.
 */

using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando um novo Funcionário da classe Funcionário
            Funcionario funcionario = new Funcionario();

            Console.Write("Informe o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Informe o salário bruto do funcionário: ");
            funcionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o valor do imposto: R$");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioDescontado = funcionario.SalarioLiquido(funcionario.Salario, funcionario.Imposto);

            Console.WriteLine($"Funcionário: {funcionario.Nome}\n Salário: R${salarioDescontado.ToString("f2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("Deseja aumentar o salário do " + funcionario.Nome + " em quantos procento?");
            Console.Write("Digite o valor: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            funcionario.AumentarSalario(porcentagem, salarioDescontado);

            Console.ReadKey();
        }
    }
}