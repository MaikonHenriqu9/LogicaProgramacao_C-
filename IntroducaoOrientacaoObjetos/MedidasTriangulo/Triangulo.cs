using System;

namespace Exercicio { 
	class Triangulo	{
		/*Esses atributos serão acessados através de outros arquivos*/
		public double A;
		public double B;
		public double C;

		/*Método da classe Triângulo para cálcular a sua área*/
		public double CalcularArea()
		{
            double perimetro = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(perimetro * (perimetro - A) * (perimetro - B) * (perimetro - C));
			return raiz;
        }

	}
}