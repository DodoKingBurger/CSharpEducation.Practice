using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Practics8.Task4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> list = new List<string>() { "danil", "stas", "denis" };
			MainMenu(list);
		}
		static void MainMenu(List<string> list)
		{
			Console.Write($"Исходный cписок слов: ");
			PrintList(list);
			Console.WriteLine("Выберите операцию:");
			Console.WriteLine("1. Сделать первые буквы заглавными");
			Console.WriteLine("2. Перевернуть слова");
			int choice = int.Parse(Console.ReadLine());
			switch (choice)
			{
				case 1:
					for (int i = 0; i < list.Count; i++)
					{
						list[i] = DoOperation(list[i], FirstCharChange);
					}
					PrintList(list);
					break;
				case 2:
					for (int i = 0; i < list.Count; i++)
					{
						list[i] = DoOperation(list[i], ReverseString);
					}
					PrintList(list);
					break;
				default:
					throw new ArgumentException("Неверный выбор операции.");
			}
			MainMenu(list);
		}
		static string FirstCharChange(string str)
		{
			char[] chars = str.ToCharArray();
			if (chars[0] == 'd')
				chars[0] = 'p';
			string strF = chars[0].ToString();
			return strF.ToUpper() + (str.Length > 1 ? str.Substring(1) : "");
		}
		static string ReverseString(string str)
		{
			char[] arr = str.ToCharArray();
			Array.Reverse(arr);
			return new string(arr);
		}
		static string DoOperation(string str, Func<string, string> func)
		{
			return func(str);
		}
		static void PrintList(List<string> list)
		{
			foreach (string str in list)
			{
				Console.Write(str + " ");
			}
			Console.WriteLine();
		}
	}
}
