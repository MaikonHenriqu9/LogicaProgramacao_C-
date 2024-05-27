/*  Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e 
    mostre o valor que esta pessoa deve pagar de Imposto de Renda.
    Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de 
    salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é 
    de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com 
    duas casas decimais. */


using System;
using System.Globalization;

namespace Exercicio{
    class Exercicio8{
        static void Main(string[] args){

            double salario, imposto;
            Console.Write("Digite o valor do seu salário: ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            imposto = CalcularImpostoDeRenda(salario);

            string mensagem = imposto == 0.0 ? "Isento de imposto" : $"Valor do Imposto: R${imposto.ToString("f2", CultureInfo.InvariantCulture)}";


            Console.WriteLine(mensagem);

            Console.ReadKey();

        }

        static double CalcularImpostoDeRenda(double salario) {

            double valor;

            if(salario <= 2000.00) {
                valor = 0.0;

            } else if (salario <= 3000.00) {
                valor = (salario - 2000) * 0.08;

            } else if (salario <= 4500.00) {
                valor = ((salario - 3000) * 0.18) + 1000 * 0.08;

            } else {
                valor = ((salario - 4500) * 0.28 ) + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            return valor;
        }

    }
}