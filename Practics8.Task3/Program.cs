using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static Practics8.Task3.BankAccount;

namespace Practics8.Task3
{
	internal class Program
	{
		public delegate void AccountTransactionDelegate(decimal sum, TransactionType transactionType);
		static void Main(string[] args)
		{
			BankAccount account = new BankAccount(1000);
			AccountTransactionDelegate BotDoWorker = account.DoOperation;
			MainMenu(account, BotDoWorker);
		}
		static void MainMenu(BankAccount account, AccountTransactionDelegate BotDoWorker)
		{
			Console.Write($"Исходный баланс пользователя: {account.Balance}");
			Console.WriteLine("Выберите операцию:");
			Console.WriteLine("1. Пополнить");
			Console.WriteLine("2. Снять");
			int choice = int.Parse(Console.ReadLine());
			switch (choice)
			{
				case 1:
					Console.Write("На какую сумму хотите пополнить? - ");
					if (decimal.TryParse(Console.ReadLine(), out decimal dSum))
					{
						BotDoWorker(dSum, TransactionType.Deposit);
						Console.WriteLine($"Баланс пополен на {dSum}.\nБаланс: {account.Balance}");
					}
					else
						throw new ArgumentException("Сумма для пополнения не читайма");
					break;
				case 2:
					Console.Write("Какую сумму хотите снять? - ");
					if (decimal.TryParse(Console.ReadLine(), out decimal wSum))
					{
						BotDoWorker(wSum, TransactionType.Withdraw);
						Console.WriteLine($"Со счета снято {wSum}\nБаланс: {account.Balance}");
					}
					else
						throw new ArgumentException("Сумма для снятия не читайма");
					break;
				default:
					throw new ArgumentException("Неверный выбор операции.");
			}
			MainMenu(account, BotDoWorker);
		}
	}
}
