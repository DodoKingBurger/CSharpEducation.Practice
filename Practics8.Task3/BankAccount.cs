using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Practics8.Task3
{
	public class BankAccount
	{
		private decimal balance;
		public delegate void TransactionDelegate(decimal sum);
		public TransactionDelegate operation { get; set; }
		public enum TransactionType
		{
			Deposit,
			Withdraw
		}
		public decimal Balance
		{
			get
			{
				return this.balance;
			}
			set
			{
				if (value > 0)
					this.balance = value;
			}
		}

		public void Deposit(decimal cash)
		{
			if (cash <= 0)
				throw new ArgumentException($"Введенная сумма не может быть меньше 0.\nБаланс: {this.balance}");
			else
			{
				this.balance += cash;
			}
		}

		public void Withdraw(decimal cash)
		{
			if (cash > this.balance)
				throw new Exception($"Запрашиваемая сумма больше вашего баланса.\nБаланс: {this.balance}");
			else
			{
				this.balance -= cash;
			}
		}

		public void DoOperation(decimal sum, TransactionType typeOperation)
		{
			switch (typeOperation)
			{
				case TransactionType.Deposit:
					operation = Deposit;
					break;
				case TransactionType.Withdraw:
					operation = Withdraw;
					break;
			}
			if (operation != null)
				operation(sum);
			else
				throw new ArgumentNullException("Операция переданная Боту транзакций не ясна");
		}

		public BankAccount(decimal initialBalance)
		{
			balance = initialBalance;
		}
	}
}
