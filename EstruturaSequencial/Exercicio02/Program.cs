/* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor 
   da área deste círculo com quatro casas decimais conforme exemplos.
   Fórmula da área: area = π . raio2
   Considere o valor de π = 3.14159 
*/

using System;
using System.Globalization;

namespace Exercicios
{
    class Exercicio02
    {
        static void Main(string[] args)
        {
            double raio, area, pi;
            pi = 3.14159;

            Console.Write("Digite o valor do raio de um circulo: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine($"A área de {raio} é : {area.ToString("f4", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}