/*
    Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema 
    cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo 
    menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
*/

using System;
using System.Globalization;

namespace Exercicios {
    class Exercicios {
        static void Main(string[] args) {
            Console.WriteLine("Plano Cartesiano");
            Console.Write("Digite os valores de X e Y: ");
            string[] valores = Console.ReadLine().Split(' ');
            double valorX = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double valorY = double.Parse(valores[1], CultureInfo.InvariantCulture);

            while (valorX != 0 || valorY != 0)
            {

                if (valorX > 0.0 && valorY > 0.0)
                {
                    Console.WriteLine("primeiro");

                }
                else if (valorX < 0 && valorY > 0)
                {
                    Console.WriteLine("segundo");

                }
                else if (valorX < 0 && valorY < 0)
                {
                    Console.WriteLine("terceiro");

                }
                else if (valorX > 0 && valorY < 0)
                {
                    Console.WriteLine("quarto");

                }
                else
                {
                    Console.WriteLine("Origem");
                }

                Console.Write("Digite os valores de X e Y: ");
                valores = Console.ReadLine().Split(' ');
                valorX = double.Parse(valores[0], CultureInfo.InvariantCulture);
                valorY = double.Parse(valores[1], CultureInfo.InvariantCulture);
            }

        }
    }
}