/*
    Digitar um número e depois N valores inteiros. Mostrar a soma dos N
    valores digitados.
*/

using System;

namespace Exercicios {
    class Exercicios {
        static void Main(string[] args) {
            Console.Write("Quantos números inteiros você deseja somar? ");
            int quantidade = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= quantidade; i++){
                Console.Write($"Digite o {i}° valor: ");
                int valor = int.Parse(Console.ReadLine());

                soma = soma + valor;

            }

            Console.WriteLine($"\nResultado: {soma}");
            Console.ReadKey();

        }
    }
}