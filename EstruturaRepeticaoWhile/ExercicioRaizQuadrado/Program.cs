/*
    Digitar um número e mostrar sua raiz quadrada com três casas decimais,
    depois repetir o procedimento. Quando o usuário digitar um número
    negativo (podendo inclusive ser na primeira vez), mostrar uma mensagem
    "Número negativo" e terminar o programa.
*/

using System;
using System.Globalization;

namespace Exercicios {
    class Exercicios {
        static void Main(string[] args) {

            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while(numero > 0) {
                double raiz = Math.Sqrt(numero);
                Console.WriteLine($"{raiz.ToString("f3", CultureInfo.InvariantCulture)}");

                Console.Write("Digite outro número: ");
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número Negativo");    
            Console.ReadKey();

        }
    }

}