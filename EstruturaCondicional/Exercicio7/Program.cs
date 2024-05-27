/*  Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. 
    A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
    Se o ponto estiver na origem, escreva a mensagem “Origem”.
    Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a 
    situação. */

using System;
using System.Globalization;

namespace Exercicio {
    class Exercicio7{
        static void Main(string[] args){

            Console.WriteLine("Plano Cartesiano");
            Console.Write("Digite os valores de X e Y: ");
            string[] valores = Console.ReadLine().Split(' ');
            double valorX = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double valorY = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if(valorX > 0.0 && valorY > 0.0) {
                Console.WriteLine("Q1");

            } else if(valorX < 0 && valorY > 0) {
                Console.WriteLine("Q2");

            } else if (valorX < 0 && valorY < 0) {
                Console.WriteLine("Q3");

            } else if (valorX > 0 && valorY < 0) {
                Console.WriteLine("Q4");

            } else {
                Console.WriteLine("Origem");
            }


            Console.ReadKey();
        }
    }
}