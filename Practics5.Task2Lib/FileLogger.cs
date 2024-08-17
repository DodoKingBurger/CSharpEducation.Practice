using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics5.Task2Lib
{
    public class FileLogger : ILogger
    {
      private string className;
      private string path; 
      public string Path { get { return this.path; } set { this.path = value; } }
      public string Class { get { return this.className; } set { this.className = value; } }
      public void Trace(string str)
      {
        Log(str, LogLevel.Trace);
      }
      public void Info(string str)
      {
        Log(str, LogLevel.Info);
      }
      public void Debug(string str)
      {
        Log(str, LogLevel.Debug);
      }
      public void Warning(string str)
      {
        Log(str, LogLevel.Warning);
      }
      public void Error(string str)
      {
        Log(str, LogLevel.Error);
      }
      public void Fatal(string str)
      {
        Log(str, LogLevel.Fatal);
      }
      public void Log(string str, LogLevel level)
      {
        string message = $"{DateTime.Now} | {Class} | {level} | {str}";
        File.WriteAllText(path, message);
      }
      public FileLogger(string className = "Неизвезстно")
      {
        Class = className;
        this.path = AppDomain.CurrentDomain.BaseDirectory + DateTime.Now.ToString() + AppDomain.CurrentDomain.FriendlyName + ".log";
        if(File.Exists(this.path))
        {
          throw new Exception("Фаил уже существует");
        }
        else
        {
          File.Create(this.path);
        }
      }
  }
}
