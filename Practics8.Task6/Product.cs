using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics8.Task6
{
	/// <summary>
	/// Продукт.
	/// </summary>
	public class Product
	{
		/// <summary>
		/// Название продукта.
		/// </summary>
		public string ProductName { get; }
		/// <summary>
		/// Стоймость продукта.
		/// </summary>
		public float ProductPrace { get; }
		/// <summary>
		/// Создает экземпляр продукта.
		/// </summary>
		/// <param name="productName">Название продукта.</param>
		/// <param name="productPrace">Стоймость продукта.</param>
		public Product(string productName, float productPrace)
		{
			this.ProductName = productName;
			this.ProductPrace = productPrace;
		}
	}
}
