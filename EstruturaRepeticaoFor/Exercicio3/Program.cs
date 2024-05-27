/*
Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste 
de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes 
conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem 
peso 5.
*/

using System;
using System.Globalization;

namespace Exercicios {
    class Exercicios {
        static void Main(string[] args){
            Console.WriteLine("Digite quantos casos de teste que deseja realizar: ");
            int quantidadeTestes = int.Parse(Console.ReadLine());
            double valor1 = 0.0; 
            double valor2 = 0.0; 
            double valor3 = 0.0;
            double media = 0.0;

            for(int i = 0; i < quantidadeTestes; i++){

                Console.Write("Digite o primeiro valor: ");
                valor1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                valor2 = double.Parse(Console.ReadLine());
                Console.Write("Digite o terceiro valor: ");
                valor3 = double.Parse(Console.ReadLine());

                media = (valor1 * 2.0 + valor2 * 3.0 + valor3 * 5.0) / 10.0;

                Console.WriteLine($"Média: {media.ToString("f1", CultureInfo.InvariantCulture)}\n");

            }

            Console.ReadKey();

        }
    }
}