// Ler um número inteiro N e calcular todos os seus divisores.

using System;

namespace Exercicios { 
    class Exercicios {
        static void Main(string[] args){
            Console.Write("Digite um valor para saber os seus divisores: ");
            int divisor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= divisor; i++){
                if(divisor % i == 0){
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();

        }
    }
}