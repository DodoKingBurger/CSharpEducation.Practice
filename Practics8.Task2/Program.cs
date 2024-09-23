using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics8.Task2
{
	class Program
	{
		static void Main()
		{
			List<string> strings = new List<string> { "apple", "banana", "cherry", "date", "elderberry", "fig", "grape" };
			Console.WriteLine("Исходный список строк:");
			PrintStrings(strings);
			Console.WriteLine("Выберите условие фильтрации:");
			Console.WriteLine("1. Строки, начинающиеся с 'a'");
			Console.WriteLine("2. Строки, длина которых больше 5 символов");
			Console.WriteLine("3. Строки, содержащие букву 'e'");
			int choice = int.Parse(Console.ReadLine());
			Predicate<string> predicate;
			switch (choice)
			{
				case 1:
					predicate = StartsWithA;
					break;
				case 2:
					predicate = LongerThanFive;
					break;
				case 3:
					predicate = ContainsE;
					break;
				default:
					Console.WriteLine("Неверный выбор. Используется фильтрация по строкам, начинающимся с 'a'.");
					predicate = StartsWithA;
					break;
			}
			List<string> filteredStrings = FilterStrings(strings, predicate);
			Console.WriteLine("Отфильтрованный список строк:");
			PrintStrings(filteredStrings);
		}

		/// <summary>
		/// Метод для вывода списка строк.
		/// </summary>
		/// <param name="strings">Список строк.</param>
		static void PrintStrings(List<string> strings)
		{
			foreach (string str in strings)
			{
				Console.WriteLine(str);
			}
			Console.WriteLine();
		}

		/// <summary>
		/// Метод для фильтрации списка строк.
		/// </summary>
		/// <param name="strings">Список строк, которые нужно отсортировать.</param>
		/// <param name="predicate">Метод сортировки.</param>
		/// <returns>Список отсортированных строк.</returns>
		static List<string> FilterStrings(List<string> strings, Predicate<string> predicate)
		{
			List<string> filteredList = new List<string>();
			foreach (string str in strings)
			{
				if (predicate(str))
				{
					filteredList.Add(str);
				}
			}
			return filteredList;
		}

		/// <summary>
		/// Метод для проверки, начинается ли строка с 'a'
		/// </summary>
		/// <param name="str">Строка.</param>
		/// <returns>True, если строка начинается с 'а', иначе False.</returns>
		static bool StartsWithA(string str)
		{
			return str.StartsWith("a");
		}

		/// <summary>
		/// Метод для проверки, длина строки больше 5 символов.
		/// </summary>
		/// <param name="str">Строка.</param>
		/// <returns>True, если длинна строка больше 5 символов, иначе False.</returns>
		static bool LongerThanFive(string str)
		{
			return str.Length > 5;
		}

		/// <summary>
		/// Метод для проверки, содержит ли строка букву 'e'.
		/// </summary>
		/// <param name="str">Строка.</param>
		/// <returns>True, если строка начинается с 'е', иначе False.</returns>
		static bool ContainsE(string str)
		{
			return str.Contains("e");
		}
	}
}
