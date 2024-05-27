/*
  Fazer um programa que leia três valores com ponto flutuante de dupla precisão: 
  A, B e C. Em seguida, calcule e mostre: 
  a) a área do triângulo retângulo que tem A por base e C por altura. 
  b) a área do círculo de raio C. (pi = 3.14159) 
  c) a área do trapézio que tem A e B por bases e C por altura. 
  d) a área do quadrado que tem lado B. 
  e) a área do retângulo que tem lados A e B.
*/

using System;
using System.Globalization;

namespace Exercicios
{
    class Exercicio06
    {
        static void Main(string[] args)
        {
            double valorA, valorB, valorC, areaTriangulo, areaCirculo, pi, areaTrapezio, areaQuadrado, areaRetangulo;
            pi = 3.14159;
            Console.Write("Informe três valores: ");
            string[] valores = Console.ReadLine().Split(' ');

            valorA = double.Parse(valores[0], CultureInfo.InvariantCulture);
            valorB = double.Parse(valores[1], CultureInfo.InvariantCulture);
            valorC = double.Parse(valores[2], CultureInfo.InvariantCulture);

            areaTriangulo = valorA*valorC / 2.0;
            areaCirculo = pi * Math.Pow(valorC, 2);
            areaTrapezio = (valorA + valorB) * valorC / 2;
            areaQuadrado = valorB * valorB;
            areaRetangulo = valorA * valorB;

            Console.WriteLine($"Área do Triângulo: {areaTriangulo.ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área do Circulo: {areaCirculo.ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área do Trapézio: {areaTrapezio.ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área do Quadrado: {areaQuadrado.ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área do Retângulo: {areaRetangulo.ToString("f3",CultureInfo.InvariantCulture)}");

            Console.ReadKey();

        }
    }
}