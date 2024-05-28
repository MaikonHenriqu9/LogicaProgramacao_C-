using System;
using System.Globalization;

namespace Program {
    class Program {
        static void Main(string[] args) {

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Medidas do Primeiro Triângulo");
            Console.Write("Digite o primeiro valor do triangulo: ");
            x.A = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor do triangulo: ");
            x.B = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor do triangulo: ");
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("\nMedidas do Segundo Triângulo");
            Console.Write("Digite o primeiro valor do triangulo: ");
            y.A = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor do triangulo: ");
            y.B = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor do triangulo: ");
            y.C = double.Parse(Console.ReadLine());

            double perimetro = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(perimetro * (perimetro - x.A) * (perimetro - x.B) * (perimetro - x.C));

            perimetro = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(perimetro * (perimetro - y.A) * (perimetro - y.B) * (perimetro - y.C));

            Console.WriteLine($"\nÁrea do primeiro triângulo: {areaX.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Àrea do segundo triângulo: {areaY.ToString("f2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}