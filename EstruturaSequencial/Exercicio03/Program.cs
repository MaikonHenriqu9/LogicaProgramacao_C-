/* Fazer um programa para ler quatro valores inteiros A, B, C e D. 
   A seguir, calcule e mostre a diferença do produto 
   de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).*/

using System;

namespace Exercicio
{
    class Exercicio03
    {
        static void Main(string[] args)
        {
            
            int produtoA, produtoB, produtoC, produtoD, diferenca;

            Console.Write("Digite o valor do produto A : ");
            produtoA = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor do produto B : ");
            produtoB = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor do produto C : ");
            produtoC = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor do produto D : ");
            produtoD = int.Parse(Console.ReadLine());

            diferenca = (produtoA*produtoB - produtoC*produtoD);

            Console.WriteLine($"A diferença do produto A e B para o produto C e D é : {diferenca}");
            Console.ReadKey();
        }
    }
}