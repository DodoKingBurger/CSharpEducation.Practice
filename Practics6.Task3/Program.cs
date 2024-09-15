using Practics6.Task3.MyException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics6.Task3
{
  internal class Program
  {
    static GuardClub Ivan;
    static void Main(string[] args)
    {
      Console.OutputEncoding = Encoding.GetEncoding(1251);
      Ivan = new GuardClub();
      FaceControl();
      Console.ReadLine();
    }
    /// <summary>
    /// Фэйс контроль перед клубом.
    /// </summary>
    static void FaceControl()
    {
      try
      {
        Console.Write("Фэйс контроль приветственно махает\nОхранник - \"Скажите сколько вам лет, чтобы я мог удостовериться что могу вас пропустить\"\nВы - ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
          if (age < 18)
          {
            new SmallAgeException("Охранник - \"Малолетка что ли?\n\"(Не можешь нормально возраст сообщить)Охранник - \"Давай я тип не слышал, еще раз\n\"");
          }
          else
          {
            Console.WriteLine("Охранник - \"Проходи шутник) Удачного отдыха!\"");
            return;
          }
        }
        else
        {
          new NotLegibleSpeechException("Охранник - \"Что с тобой? Не можешь нормально возраст сообщить\"");
        }
      }      
      catch (TooManyAttemptsException ex)
      {
        Console.WriteLine(ex.Message);
      }
      catch (NotLegibleSpeechException ex)
      {        
        Ivan.PatienceGuard++;
        Console.WriteLine(ex.Message);
        FaceControl();
      }
      catch (SmallAgeException ex) 
      {        
        Ivan.PatienceGuard++;
        Console.WriteLine(ex.Message);
        FaceControl();
      }
    }
  }
}
