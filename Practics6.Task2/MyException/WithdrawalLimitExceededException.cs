using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics6.Task2.MyException
{
  internal class WithdrawalLimitExceededException : Exception
  {
    /// <summary>
    /// Исключение об операции которая приведёт к отрицательной сумме баланса.
    /// </summary>
    /// <param name="message">Сообщение об ошибкой.</param>
    public WithdrawalLimitExceededException(string message) : base(message)
    { }
  }
}
