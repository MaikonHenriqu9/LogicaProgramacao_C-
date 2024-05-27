/*
    Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo 
    segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel" 
*/

using System;
using System.Globalization;

namespace Exercicios {
    class Exercicios {
        static void Main(string[] args) {
            Console.Write("Quantas divisões deseja realizar? ");
            int quantidadeDivisoes = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= quantidadeDivisoes; i++){
                Console.Write("Digite o valor do numerador: ");
                int numerador = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor do denominador: ");
                int denominador = int.Parse(Console.ReadLine());

                if(denominador == 0){
                    Console.WriteLine("Divisao impossivel");
                } 
                else {
                    double resultado =  (double) numerador / denominador;
                    Console.WriteLine($"Resultado: {resultado.ToString("f1", CultureInfo.InvariantCulture)}");
                }

                Console.WriteLine("\n");
            }

            Console.WriteLine("FIM");
            Console.ReadKey();

        }
    }
}