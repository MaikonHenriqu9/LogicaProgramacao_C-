using System;
using System.Globalization;

namespace Exercicio {
    class Program {
        static void Main(string[] args) {

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Medidas do Primeiro Triângulo");
            Console.Write("Digite o primeiro valor do triangulo: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo valor do triangulo: ");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o terceiro valor do triangulo: ");
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double areaX = x.CalcularArea();

            Console.WriteLine("\nMedidas do Segundo Triângulo");
            Console.Write("Digite o primeiro valor do triangulo: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo valor do triangulo: ");
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o terceiro valor do triangulo: ");
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double areaY = y.CalcularArea();

            Console.WriteLine(areaX);
            Console.WriteLine(areaY);

            Console.ReadKey();
        }



    }
}