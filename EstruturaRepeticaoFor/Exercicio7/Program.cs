/*
    Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
    começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme 
    exemplo.
*/

using System;

namespace Exercicios { 
    class Exercicios {
        static void Main(string[] args){
            Console.Write("Digite um valor: ");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++){
                int linha = i;
                int quadrado = i * i;
                int cubo = i * i * i;
                Console.WriteLine($"Linha: {linha}  Valor Quadrado: {quadrado}  Valor Cubo: {cubo}");
            }

            Console.ReadKey();

        }
    }
}