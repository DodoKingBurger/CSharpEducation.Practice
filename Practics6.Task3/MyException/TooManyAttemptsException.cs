using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics6.Task3.MyException
{
  internal class TooManyAttemptsException : Exception
  {
    /// <summary>
    /// Исключение о большом количестве попыток пройти проверку на возраст.
    /// </summary>
    /// <param name="message">Сообщение об ошибкой.</param>
    public TooManyAttemptsException(string message) : base(message) { }
  }
}
