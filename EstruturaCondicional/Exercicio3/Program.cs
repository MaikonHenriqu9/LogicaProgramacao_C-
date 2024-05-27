/* Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
    Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
    ordem crescente ou decrescente
*/

using System;

namespace Exercicios { 
    class Exercicio3
    {
        static void Main(string[] args)
        {
            int valorA, valorB;
            Console.Write("Digite o primeiro valor: ");
            valorA = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            valorB = int.Parse(Console.ReadLine());

            string resultado = valorA % valorB == 0 || valorB % valorA == 0 ? "são multiplos" : "não são multiplos";
            Console.WriteLine($"{valorA} e {valorB} {resultado}");
            Console.ReadKey();

        }
    }
}