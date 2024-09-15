using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics6.Task3.MyException
{
  internal class SmallAgeException : Exception
  {
    /// <summary>
    /// Исключение  о том, что пользователь несовершеннолетний.
    /// </summary>
    /// <param name="message">Сообщение об ошибкой.</param>
    public SmallAgeException(string message) : base(message) { }
  }
}
