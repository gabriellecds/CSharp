using System;
namespace DollarRate
{
	public class ConversorDeMoeda
	{
		public double Cotacao;
		public double Compra;

		public double ValorAPagar()
		{
			double Conversao = Cotacao * Compra;
			return Conversao + (Conversao * 0.06); 
		}

	}
}

