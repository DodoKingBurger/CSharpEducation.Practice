using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics8.Task6
{
	/// <summary>
	/// Магазин.
	/// </summary>
	public class ProductShops
	{
		/// <summary>
		/// Событие о завершение покупки.
		/// </summary>
		/// <param name="sender">Продавец.</param>
		/// <param name="args">Информация о покупки.</param>
		public delegate void PurchaseCompleted(ProductShops sender, ProductEventArgs args);
		
		public event PurchaseCompleted Notify;

		/// <summary>
		/// Список продаваймых продуктов.
		/// </summary>
		public Dictionary<Product,int> ProductList = new Dictionary<Product, int>()
		{
			{new Product("Bread", 10.54F),10},
			{new Product("Milk", 169), 10},
			{new Product("Water", 54), 10},
			{new Product("Matches", 12), 10}
		};

		/// <summary>
		/// Покупка продукта.
		/// </summary>
		/// <param name="product">Продукт.</param>
		/// <param name="quantity">Колличество продукта.</param>
		/// <exception cref="IndexOutOfRangeException">Нехватка продукта.</exception>
		/// <exception cref="ArgumentNullException">Нет такого продукта.</exception>
		public void BayProduct(Product product,int quantity)
		{
			if (ProductList.TryGetValue(product, out int quantityAvailable))
			{
				if ((quantityAvailable - quantity) >= 0)
				{
					ProductList[product] = quantityAvailable - quantity;
					this.Notify?.Invoke(this, new ProductEventArgs(product, quantity));
				}
				else
					throw new IndexOutOfRangeException($"Продукта {product.ProductName} не хватает на складе, сейчас есть только {quantityAvailable} шт.");
			}
			else
				throw new ArgumentNullException($"Таких продуктов {product.ProductName} - нет в нашем магазине");
		}
	}
}
