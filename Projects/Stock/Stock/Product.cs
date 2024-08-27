using System;
using System.Globalization;

namespace Stock
{
	public class Product
	{

		public string Nome;
		public double Preco;
		public int Qte;

		public double ValorTotalEmEstoque()
		{
			return Preco * Qte;
		}

		public void AdicionarProdutos(int quantidade)
		{
			Qte += quantidade; 
		}

		public void RemoverProdutos(int quantidade)
		{
			Qte -= quantidade;
		}

        public override string ToString()
        {
			return Nome
				+ ", $"
				+ Preco.ToString("F2", CultureInfo.InvariantCulture)
				+ ", "
				+ Qte
				+ " unidades, Total: $"
				+ ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

