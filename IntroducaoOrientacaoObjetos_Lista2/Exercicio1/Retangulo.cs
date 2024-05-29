/*
    Fazer um programa para ler os valores da largura e altura de um ret�ngulo. Em 
    seguida, mostrar na tela o valor de sua �rea, per�metro e diagonal. Usar uma classe 
    como mostrado no projeto ao lado.
*/

using System;

namespace Exercicios
{
	class Retangulo
	{
		public double Altura;
		public double Largura;

		// M�todo respons�vel por calcular a �rea de um retangulo
		public double Area(double Altura, double Largura)
		{
			return Largura * Altura;
		}

		// M�todo respons�vel pelo c�lulo do Per�metro do ret�ngulo
		public double Perimetro(double Altura, double Largura)
		{
			return 2 * (Largura + Altura);
		}
		
		// M�todo respons�vel pelo c�lculo da diagonal do ret�ngulo
		public double Diagonal(double Altura, double Largura)
		{
			return Math.Sqrt(Largura * Largura + Altura * Altura);
		}
		
	}
}