using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practics6.Task1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.OutputEncoding = Encoding.GetEncoding(1251);
      Task1();
    }

    static void Task1()
    {
      RequestSomething();
      void RequestSomething()
      {
        try
        {
          Console.Write("Ввведите первое число: ");
          if (float.TryParse(Console.ReadLine(), out float a))
          {
            Console.Write("Ввведите второе число: ");
            if (float.TryParse(Console.ReadLine(), out float b))
            {
              Division(a, b, out float c);
              Console.WriteLine($"Результат деления: {c}");
            }
            else
            {
              new ArgumentException("Введино не коректное число");
            }
          }
        }
        catch (ArgumentException ex)
        {
          Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
        }
        finally
        {
          RequestSomething();
        }
      }
      void Division(float a, float b, out float c)
      {
        c = 0;
        try
        {
          c = a / b;
          if (!float.IsNaN(c) || !float.IsInfinity(c))
          {
            new ArgumentException("Введино не коректное число");
            RequestSomething();
          }
        }
        catch (Exception e)
        {
          Console.WriteLine(e.Message);
        }
        finally
        {
          RequestSomething();
        }
      }
    }
    static void Task1A()
    {
      void RequestSomething()
      {
        OpenFileDialog OD = new OpenFileDialog();
        OD.DefaultExt = ".txt";
        OD.Filter = "Text documents (.txt)|*.txt";
        try
        {
          if (OD.ShowDialog() == DialogResult.OK)
          {
            float a;
            float b;
            ReadFile(OD.FileName, out a, out b);
            if (float.TryParse(Console.ReadLine(), out a))
            {
              if (float.TryParse(Console.ReadLine(), out b))
              {
                Division(a, b, out float c);
                Console.WriteLine($"Результат деления: {c}");
              }
              else
              {
                new ArgumentException("Введено некорректное число");
              }
            }
            else
            {
              new ArgumentException("Введено некорректное число");
            }
          }
          else
          {
            new FileNotFoundException("Файл отсутствует или Диалоговое окно не открылось");
          }
        }
        catch (FileNotFoundException ex)
        {
          Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
          Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
        }
        finally
        {
          RequestSomething();
        }
      }
      void Division(float a, float b, out float c)
      {
        c = 0;
        try
        {
          c = a / b;
          if (!float.IsNaN(c) || !float.IsInfinity(c))
          {
            new ArgumentException("Введино не коректное число");
          }
        }
        catch (ArgumentException ex)
        {
          Console.WriteLine(ex.Message);
        }
        catch (Exception e)
        {
          Console.WriteLine(e.Message);
        }
        finally
        {
          RequestSomething();
        }
      }
      void ReadFile(string path, out float a, out float b)
      {
        try
        {
          string line;
          StreamReader srt = new StreamReader($"{path}");
          float[] number = new float[1];
          line = srt.ReadLine();
          int i = 0;
          while (i != 2)
          {
            if (float.TryParse(line, out number[i]))
            {
              i++;
            }
            else
            {
              new ArgumentException("в файле текст вместо чисел");
            }
            line = srt.ReadLine();
          }
          srt.Close();
          a = number[0];
          b = number[1];
        }
        catch (FileNotFoundException ex)
        {
          Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
          Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
        }
        finally
        {
          RequestSomething();
        }
      }
    }
  }
}
