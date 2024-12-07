using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics6.Task3.MyException
{
  internal class NotLegibleSpeechException : Exception
  {
    /// <summary>
    /// Исключение об некорректном вводе данных при диалоге с охранником.
    /// </summary>
    /// <param name="message">Сообщение об ошибкой.</param>
    public NotLegibleSpeechException(string message) : base(message) { }
  }
}
