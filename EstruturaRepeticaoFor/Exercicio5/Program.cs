/*
    Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
    Lembrando que, por definição, fatorial de 0 é 1.
*/

using System;

namespace Exercicios {
    class Exercicios {
        static void Main(string[] args) {
            Console.Write("Digite um número para saber o seu valor fatorial: ");
            int valor = int.Parse(Console.ReadLine());
            int fatorial = 1;

            if (valor > 0){
                for (int i = 1; i <= valor; i++)
                {
                    fatorial = fatorial * i;
                }

                Console.WriteLine($"Fatorial de {valor} é : {fatorial}");

            } else if (valor == 0){
                fatorial = 1;

                Console.WriteLine($"Fatorial de {valor} é : {fatorial}");
            } else {
                Console.WriteLine("Não existe fatorial de valor negativo");
            }

            Console.ReadKey();
        }
    }
}