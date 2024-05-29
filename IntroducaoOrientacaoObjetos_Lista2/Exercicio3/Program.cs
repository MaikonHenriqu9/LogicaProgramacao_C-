/*
    Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano 
    (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no 
    ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam 
    para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver 
    este problema
*/

using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando um aluno e as suas notas através da classe Aluno
            Aluno aluno = new Aluno();

            Console.Write("Informe o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Digite a primeira nota: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a segunda nota: ");
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a terceira nota: ");
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Nota final: {aluno.NotaFinal().ToString("f2", CultureInfo.InvariantCulture)}");

            if (aluno.Aprovacao())
            {
                Console.WriteLine($"{aluno.Nome} está Aprovado");
            }
            else
            {
                Console.WriteLine($"{aluno.Nome} está Reprovado");
                aluno.PontosRestantes();
            }

            Console.ReadKey();

            //aluno.ResultadoAprovacao(notaFinalResultado);


        }
    }
}