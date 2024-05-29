/*
    Fazer um programa para ler os valores da largura e altura de um retângulo. Em 
    seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe 
    como mostrado no projeto ao lado.
*/

using System;
using System.Globalization;

namespace Exercicios 
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Instanciando um objeto da classe Rêtangulo
            Retangulo retangulo = new Retangulo();

            Console.Write("Digite a alura do Rêtangulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a largura do Rêtangulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(retangulo.Altura);
            Console.WriteLine(retangulo.Largura);

            double areaRetangulo = retangulo.Area(retangulo.Altura, retangulo.Largura);
            double perimetroRetangulo = retangulo.Perimetro(retangulo.Altura, retangulo.Largura);
            double diagonalRetangulo = retangulo.Diagonal(retangulo.Altura, retangulo.Largura);

            Console.WriteLine($"Área do Rêtangulo : {areaRetangulo.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Périmetro do Rêtangulo: {perimetroRetangulo.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal do Retângulo: {diagonalRetangulo.ToString("f2", CultureInfo.InvariantCulture)}");


            Console.ReadKey();
        }
    }
}