using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics6.Task2.MyException
{
  /// <summary>
  /// Накопительный счёт.
  /// </summary>
  internal class SavingsAccount : BankAccount
  {
    #region Поля и свойства 

    /// <summary>
    /// Дата последнего снятия денег со счета.
    /// Деньги с накопительного счета можно снимать только раз в месяц!
    /// </summary>
    private DateTime dateLastRemovingMoney;
    #endregion
    #region Базовый класс

    public override void RemovingMoney(float money)
    {
      if(dateLastRemovingMoney != null)
      {
        if (dateLastRemovingMoney.AddMonths(1) <= DateTime.Now)
        {
          if ((MoneyAccount - money) >= 0)
          {
            MoneyAccount -= money;
            dateLastRemovingMoney = DateTime.Now;
          }
          else
          {
            throw new InsufficientBalanceException("На счету недостаточно средств.");
          }
        }
        else 
        {
          throw new WithdrawalLimitExceededException($"Операция недоступна. Деньги с накопительного счета можно снимать только раз в месяц! Операция доступна с {dateLastRemovingMoney.AddMonths(1).ToString()}");
        }
      }
      else
      {
        if ((MoneyAccount - money) >= 0)
        {
          MoneyAccount -= money;        
          dateLastRemovingMoney = DateTime.Now;
        }
        else
        {
          throw new InsufficientBalanceException("На счету недостаточно средств.");
        }
      }
    }
    #endregion
    #region Конструкторы

    /// <summary>
    /// Создания нового накопительного счета.
    /// </summary>
    /// <param name="money">Деньги которые будут храниться на счету.</param>
    public SavingsAccount(float money) : base(money)
    { }
    #endregion
  }
}
