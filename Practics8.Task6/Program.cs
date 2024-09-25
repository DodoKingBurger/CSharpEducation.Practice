using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practics8.Task6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var Magnit = new ProductShops();
			Magnit.Notify += SendSMS;
			MainMenu(Magnit);
		}
		static public void SendSMS(ProductShops shops, ProductEventArgs args)
		{
			Console.WriteLine($"Была совершна покупка {args.ProductName} {args.Quantity} шт.," +
				$" на общую сумму {args.Prace}");
		}
		static void MainMenu(ProductShops shops)
		{
			Console.Write($"Доступные продукты: \n");
			int numberList = 1;
			foreach (var product in shops.ProductList) 
			{
				Console.WriteLine($"{numberList}. {product.Key.ProductName}, по цене {product.Key.ProductPrace}");
				numberList++;
			}
			Console.Write("Выберите продукт: ");
			int choice = int.Parse(Console.ReadLine());					
			Console.Write("Сколько ? ");
			int quantity = int.Parse(Console.ReadLine());
			switch (choice)
			{
				case 1:
					shops.BayProduct(shops.ProductList.ElementAt(0).Key,quantity);
					break;
				case 2:
					shops.BayProduct(shops.ProductList.ElementAt(1).Key, quantity);
					break;
				case 3:
					shops.BayProduct(shops.ProductList.ElementAt(2).Key, quantity);
					break;
				case 4:
					shops.BayProduct(shops.ProductList.ElementAt(3).Key, quantity);
					break;
				default:
					throw new ArgumentException("Нет продукта под таким номером.");
			}
			MainMenu(shops);
		}
	}
}
