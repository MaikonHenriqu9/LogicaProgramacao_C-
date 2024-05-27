/*  Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
    seguir, calcule e mostre o valor da conta a pagar */

using System;
using System.Globalization;

namespace Exercicios
{
    class Exercicio5
    {
        static void Main(string[] args)
        {
            int codigoDoProduto, quantidadeDoProduto;
            double valorDaConta;
            Console.WriteLine("CÓDIGO   ESPECIFICAÇÃO   PREÇO");
            Console.WriteLine("1   Cachorro Quente   R$4,00\n2   X-Salada   R$4.50\n3   X-Bacon   R$5.00\n4   Torrada simples   R$2.00\n5   Refrigerante   R$1.50");
            Console.Write("\nDigite o código do produto: ");
            codigoDoProduto = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade que deseja comprar: ");
            quantidadeDoProduto = int.Parse(Console.ReadLine());
            valorDaConta = OpcoesDoMenu(codigoDoProduto, quantidadeDoProduto);

            Console.WriteLine("\n=================================");
            Console.WriteLine($"Total: R${valorDaConta.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.ReadKey();

        }

        static double OpcoesDoMenu(int codigo, int quantidade)
        {
            double valor = 0;

            switch (codigo)
            {
                case 1:
                    valor = quantidade * 4;
                    break;
                case 2:
                    valor = quantidade * 4.50;
                    break;
                case 3:
                    valor = quantidade * 5;
                    break;
                case 4:
                    valor = quantidade * 2;
                    break;
                case 5:
                    valor = quantidade * 1.50;
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }

            return valor;
        }

    }
}