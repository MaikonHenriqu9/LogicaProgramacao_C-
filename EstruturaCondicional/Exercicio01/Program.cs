// Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não

using System;

namespace Exercicios {
    class Exercicio01 {
       public static void Main(string[] args)
        {
            int valor;
            Console.Write("Digite um valor: ");
            valor = int.Parse(Console.ReadLine());

            string mensagem = valor > 0 ? "Não é negativo" : "É negativo";

            Console.WriteLine($"{valor} {mensagem}");
            Console.ReadKey();

        }
    }
} 