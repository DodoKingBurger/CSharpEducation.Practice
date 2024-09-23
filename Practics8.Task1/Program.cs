using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics8.Task1
{
	internal class Program
	{
		static void Main()
		{
			List<int> numbers = new List<int> { 5, 3, 9, 1, 7, 2, 8, 4, 6 };
			Console.WriteLine("Исходный список чисел:");
			PrintNumbers(numbers);
			Console.WriteLine("Выберите порядок сортировки:");
			Console.WriteLine("1. По возрастанию");
			Console.WriteLine("2. По убыванию");
			int choice = int.Parse(Console.ReadLine());
			Comparison<int> comparison;
			if (choice == 1)
			{
				comparison = AscendingComparison;
			}
			else if (choice == 2)
			{
				comparison = DescendingComparison;
			}
			else
			{
				Console.WriteLine("Неверный выбор. Используется сортировка по возрастанию.");
				comparison = AscendingComparison;
			}
			numbers.Sort(comparison);
			Console.WriteLine("Отсортированный список чисел:");
			PrintNumbers(numbers);
		}

		/// <summary>
		/// Метод для вывода списка чисел.
		/// </summary>
		/// <param name="numbers">Список чисел.</param>
		static void PrintNumbers(List<int> numbers)
		{
			foreach (int number in numbers)
			{
				Console.Write(number + " ");
			}
			Console.WriteLine();
		}

		/// <summary>
		/// Метод для сравнения чисел по возрастанию.
		/// </summary>
		/// <param name="x">Число.</param>
		/// <param name="y">Число.</param>
		/// <returns>Вернет число 1 если число больше, 0 если они равны, -1 если число меньше.</returns>
		static int AscendingComparison(int x, int y)
		{
			return x.CompareTo(y);
		}

		/// <summary>
		/// Метод для сравнения чисел по убыванию.
		/// </summary>
		/// <param name="x">Число.</param>
		/// <param name="y">Число.</param>
		/// <returns>Вернет число 1 если число больше, 0 если они равны, -1 если число меньше.</returns>
		static int DescendingComparison(int x, int y)
		{
			return y.CompareTo(x);
		}
	}
}

