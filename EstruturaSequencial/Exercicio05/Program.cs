/* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário 
   de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.
   Calcule e mostre o valor a ser pago.*/

using System;
using System.Globalization;

namespace Exercicios
{
    class Exercicio05
    {
        static void Main(string[] args)
        {
            int codigoPeca1, codigoPeca2, quantidadePecas1, quantidadePecas2;
            double valorPeca1, valorPeca2, precoTotal;

            Console.Write("Informe o valor da peça 1: ");
            codigoPeca1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de peças que precisa: ");
            quantidadePecas1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor dessa peça: ");
            valorPeca1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("---------------------");

            Console.Write("Informe o valor da peça 2: ");
            codigoPeca2 = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de peças que precisa: ");
            quantidadePecas2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor dessa peça: ");
            valorPeca2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            precoTotal = (quantidadePecas1*valorPeca1) + (quantidadePecas2*valorPeca2);

            Console.WriteLine($"Valor a pagar: R${precoTotal.ToString("f2")}");
            Console.ReadKey();

        }
    }
}