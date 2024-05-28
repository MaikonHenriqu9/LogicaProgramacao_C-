/*
    Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais 
    velha.
*/

using System;

namespace Exercicio {
    class Program {
        static void Main(string[] args) {

            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Quem é a pessoa mais velha?");
            Console.Write("Digite o nome da primeira pessoa: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Digite a sua idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o nome da segunda pessoa: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("DIgite a sua idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            string mensagem = pessoa1.Idade > pessoa2.Idade ? $"{pessoa1.Nome} é mais velho(a)" : $"{pessoa2.Nome} é mais velho(a)";

            Console.WriteLine($"\n{mensagem}");
            Console.ReadKey();

        }
    }
}