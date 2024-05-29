/*
    Fazer um programa para ler os dados de um funcionário (nome, 
    salário bruto e imposto). Em seguida, mostrar os dados do 
    funcionário (nome e salário líquido). Em seguida, aumentar o salário 
    do funcionário com base em uma porcentagem dada (somente o 
    salário bruto é afetado pela porcentagem) e mostrar novamente os 
    dados do funcionário
*/

using System;

namespace Exercicios
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        // Método responsável por realizar o cálculo do salário líquido
        public double SalarioLiquido(double Salario, double Imposto)
        {
            return Salario - Imposto;
        }

        // Método responsável por fazer o cálculo do novo salário
        public void AumentarSalario(double porcentagem, double salarioDescontado)
        {
            double novoSalario = salarioDescontado + (Salario * (porcentagem / 100));
            Console.WriteLine($"Novo salário: {novoSalario}");
        }
    }
}