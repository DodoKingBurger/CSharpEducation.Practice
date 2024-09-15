using Practics6.Task3.MyException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics6.Task3
{
  /// <summary>
  /// Охраник клуба.
  /// </summary>
  internal class GuardClub
  {
    #region Поля и свойства 

    private int patienceGuard;
    
    /// <summary>
    /// Терпение охранника, если оно поднимется до 5 уровня, будет вызвано исключение. 
    /// </summary>
    public int PatienceGuard
    {
      get { return this.patienceGuard; }
      set 
      { 
        if(value>5)
        {
          throw new TooManyAttemptsException("Слишком большое количество попыток");
        }
        else
        {
          this.patienceGuard = value; 
        }
      }
    }
    #endregion
    #region Конструкторы

    /// <summary>
    /// Охранника.
    /// </summary>
    /// <param name="patience">Стартовый уровень терпения.</param>
    public GuardClub(int patience = 0) 
    {
      PatienceGuard = patience;
    }
    #endregion
  }
}
