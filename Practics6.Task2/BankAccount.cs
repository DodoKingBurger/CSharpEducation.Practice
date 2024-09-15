using Practics6.Task2.MyException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics6.Task2
{
  /// <summary>
  /// Счёт в банке.
  /// </summary>
  internal abstract class BankAccount
  {
    #region Поля и свойства
    private float moneyAccount;

    /// <summary>
    /// Сумма на банковском счету
    /// </summary>
    public float MoneyAccount
    {
      get
      {
        return this.moneyAccount;
      }
      set
      {
        if (value < 0 || float.IsNaN(value) || float.IsInfinity(value))
        {
          throw new NegativeAmountException("На счету недостаточно средств. Пополните баланс!");
        }
        else
        {
          this.moneyAccount = value;
        }
      }
    }
    #endregion
    #region Методы

    /// <summary>
    /// Пополнение счета.
    /// </summary>
    /// <param name="money">Сумма пополнения.</param>
    public void AddMoney(float money)
    {
      if((MoneyAccount + money) >= 0)
      {
        MoneyAccount += money;
      }
      else
      {
        throw new NegativeAmountException("Эта операция приведёт к отрицательной сумме.");
      }
    }

    /// <summary>
    /// Снятие денег со счета.
    /// </summary>
    /// <param name="money">Сумма снятия.</param>
    public virtual void RemovingMoney(float money)
    {
      if ((MoneyAccount - money) >= 0)
      {
        MoneyAccount -= money;
      }
      else
      {
        throw new InsufficientBalanceException("На счету недостаточно средств.");
      }
    }
    #endregion
    #region Конструкторы

    /// <summary>
    /// Создания нового банковского счета.
    /// </summary>
    /// <param name="money">Деньги которые будут храниться на счету.</param>
    public BankAccount(float money) 
    {
      MoneyAccount = money;
    }
    #endregion

  }
}

