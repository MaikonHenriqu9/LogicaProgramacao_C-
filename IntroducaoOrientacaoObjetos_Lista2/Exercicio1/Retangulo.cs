/*
    Fazer um programa para ler os valores da largura e altura de um retângulo. Em 
    seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe 
    como mostrado no projeto ao lado.
*/

using System;

namespace Exercicios
{
	class Retangulo
	{
		public double Altura;
		public double Largura;

		// Método responsável por calcular a área de um retangulo
		public double Area(double Altura, double Largura)
		{
			return Largura * Altura;
		}

		// Método responsável pelo cálulo do Perímetro do retângulo
		public double Perimetro(double Altura, double Largura)
		{
			return 2 * (Largura + Altura);
		}
		
		// Método responsável pelo cálculo da diagonal do retângulo
		public double Diagonal(double Altura, double Largura)
		{
			return Math.Sqrt(Largura * Largura + Altura * Altura);
		}
		
	}
}