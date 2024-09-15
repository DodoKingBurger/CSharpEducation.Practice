using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics6.Task2
{   
  internal class InsufficientBalanceException : Exception
  {
    /// <summary>
    /// Исключение о недостаточном для операции баланса на счету.
    /// </summary>
    /// <param name="message">Сообщение об ошибкой.</param>
    public InsufficientBalanceException(string message):base(message)
      { }
  }
}
