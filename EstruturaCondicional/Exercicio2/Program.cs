// Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar
using System;

namespace Exercicios { 
    class Exercicio2
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Digite um valor para saber se é impar ou par: ");
            numero = int.Parse(Console.ReadLine());

            string resultado = numero % 2 == 0 ? "par" : "impar";

            Console.WriteLine($"{numero} é um valor {resultado}");
            Console.ReadLine();

        }
    }
}