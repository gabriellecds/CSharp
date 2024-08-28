using System;
using System.Globalization; 

namespace Rectangle
{
	class Rectangle
	{
		public double Largura;
		public double Altura;

		public double Area()
		{
			return Largura * Altura;
		}

		public double Perimetro()
		{
			return (2 * Largura) + (2 * Altura); 
		}

		public double Diagonal()
		{
			return Math.Sqrt((Largura * Largura) + (Altura * Altura)); 
		}
    }
}

