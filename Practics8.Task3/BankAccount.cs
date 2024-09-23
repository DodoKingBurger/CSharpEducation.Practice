using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Practics8.Task3
{
	public delegate void AccountTransactionDelegate(decimal amount, string operationType);

	public class BankAccount
	{
		private decimal _balance;
		public event AccountTransactionDelegate TransactionOccurred;

		public BankAccount(decimal initialBalance)
		{
			_balance = initialBalance;
		}

		public decimal Balance
		{
			get { return _balance; }
		}

		public void Deposit(decimal amount)
		{
			_balance += amount;
			OnTransactionOccurred(amount, "Deposit");
		}

		public void Withdraw(decimal amount)
		{
			if (amount > _balance)
			{
				throw new InvalidOperationException("Insufficient balance");
			}
			_balance -= amount;
			OnTransactionOccurred(amount, "Withdrawal");
		}

		protected virtual void OnTransactionOccurred(decimal amount, string operationType)
		{
			TransactionOccurred?.Invoke(amount, operationType);
		}
	}
}
