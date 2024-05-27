/*
    Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma 
    desses números com uma mensagem explicativa, conforme exemplos
 */

using System;

namespace Exercicio
{
    class Exercicio01
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            int soma = valor1 + valor2;

            Console.WriteLine($"O resultado de {valor1} + {valor2} é : {soma}");
            Console.ReadKey();
        }
    }
}