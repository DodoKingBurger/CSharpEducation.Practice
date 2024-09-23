using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Practics8.Task3
{
	internal class Program
	{
		public delegate void AccountTransactionDelegate(float sum, Action<float> operation);
		static void Main(string[] args)
		{
			AccountTransactionDelegate Transaction;
			BankAccount account = new BankAccount(1000);
			Console.Write($"Исходный баланс пользователя: {account.Balance}");
			Console.WriteLine("Выберите операцию:");
			Console.WriteLine("1. Пополнить");
			Console.WriteLine("2. Снять");
			int choice = int.Parse(Console.ReadLine());
			if (choice == 1)
			{
				Console.Write("На какую сумму хотите пополнить? - ");
				float.TryParse(Console.ReadLine(),out float sum);
				Transaction = account.AddMoney;
			}
			else if (choice == 2)
			{
				Console.Write("На какую сумму хотите пополнить? - ");
				float.TryParse(Console.ReadLine(), out float sum);
				Transaction = DanilAccount.AddMoney;
			}
			else
			{
				Console.WriteLine("Неверный выбор. Используется сортировка по возрастанию.");
				comparison = AscendingComparison;
			}
			Console.WriteLine("Отсортированный список чисел:");
			PrintNumbers(numbers);
			account.TransactionOccurred += (amount, operationType) =>
			{
				Console.WriteLine($"Transaction occurred: {operationType} of {amount:C}");
			};

			account.Deposit(500);
			account.Withdraw(200);
		}
	}
}
