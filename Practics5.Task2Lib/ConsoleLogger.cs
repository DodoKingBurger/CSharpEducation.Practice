using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics5.Task2Lib
{
  public class ConsoleLogger : ILogger
  {
    private string className;
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
      Console.WriteLine($"{DateTime.Now} | {Class} | {level} | {str}");
    }
    public ConsoleLogger(string className = "Неизвезстно")
    {
      Class = className;
    }
  }
}
