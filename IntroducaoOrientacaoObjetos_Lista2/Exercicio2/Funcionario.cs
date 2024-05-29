/*
    Fazer um programa para ler os dados de um funcion�rio (nome, 
    sal�rio bruto e imposto). Em seguida, mostrar os dados do 
    funcion�rio (nome e sal�rio l�quido). Em seguida, aumentar o sal�rio 
    do funcion�rio com base em uma porcentagem dada (somente o 
    sal�rio bruto � afetado pela porcentagem) e mostrar novamente os 
    dados do funcion�rio
*/

using System;

namespace Exercicios
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        // M�todo respons�vel por realizar o c�lculo do sal�rio l�quido
        public double SalarioLiquido(double Salario, double Imposto)
        {
            return Salario - Imposto;
        }

        // M�todo respons�vel por fazer o c�lculo do novo sal�rio
        public void AumentarSalario(double porcentagem, double salarioDescontado)
        {
            double novoSalario = salarioDescontado + (Salario * (porcentagem / 100));
            Console.WriteLine($"Novo sal�rio: {novoSalario}");
        }
    }
}