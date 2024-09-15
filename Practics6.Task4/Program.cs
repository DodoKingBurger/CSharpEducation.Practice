using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practics6.Task4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.OutputEncoding = Encoding.GetEncoding(1251);
      RequestFile();
    }

    static public void RequestFile()
    {
      try
      {
        OpenFileDialog OD = new OpenFileDialog();
        OD.DefaultExt = ".txt";
        OD.Filter = "Text documents (.txt)|*.txt";
        if (OD.ShowDialog() == DialogResult.OK)
        {
          ReadFile(OD.FileName);
        }
        else
        {
          new FileNotFoundException("Файл не найден или повреждён");
        }
      }
      catch (FileNotFoundException ex)
      {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Исключение, попытка получить доступ к файлу или каталогу, которых нет на диске.\nДавайте попробуем еще раз");
        RequestFile();
      }
      catch (FileLoadException ex)
      {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Исключение, управляемая сборка найдена, но не может быть загружена.\nДавайте попробуем еще раз");
        RequestFile();
      }
      catch (DirectoryNotFoundException ex)
      {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Исключение,не удается найти часть файла или каталога.\nДавайте попробуем еще раз");
        RequestFile();
      }
      catch (DriveNotFoundException ex)
      {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Исключение, попытка доступа к недоступному диску или данным совместного использования.\nДавайте попробуем еще раз");
        RequestFile();
      }
    }
    static public void ReadFile(string path)
    {       
      List<string> result = new List<string>();
      try
      {
        string line;
        StreamReader srt = new StreamReader($"{path}");
        float[] number = new float[1];
        line = srt.ReadLine();
        while (!string.IsNullOrEmpty(line))
        {
          result.Add(line);
          line = srt.ReadLine();
        }
        srt.Close();
      }
      finally 
      {
        if (result != null) 
        {
          foreach (string line in result)
          {
            Console.WriteLine(line);
          }
        }
        else
        {
          Console.WriteLine("Файл пуст");
        }
      }
    }
  }
}
