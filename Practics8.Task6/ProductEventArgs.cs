using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics8.Task6
{
	/// <summary>
	/// Информация о покупке.
	/// </summary>
	public class ProductEventArgs: EventArgs
	{
		/// <summary>
		/// Название продукта.
		/// </summary>
		public string ProductName { get; }

		/// <summary>
		/// Количество продукта.
		/// </summary>
		public int Quantity { get; }

		/// <summary>
		/// Стоймость продукта
		/// </summary>
		public float Prace { get; }

		/// <summary>
		/// Информация о покупке.
		/// </summary>
		/// <param name="product">Покупаймый продукт.</param>
		/// <param name="quantity">Количество продукта которое хотят приобрести.</param>
		public ProductEventArgs(Product product, int quantity) 
		{
			this.ProductName = product.ProductName;
			this.Prace = product.ProductPrace * quantity;			
			this.Quantity = quantity;
		}
	}
}
