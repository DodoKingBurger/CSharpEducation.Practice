﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics5.Task2Lib
{
  public interface ILogger
  {
    void Trace(string message);
    void Info(string message);
    void Debug(string message);
    void Warning(string message);
    void Error(string message); 
    void Fatal(string message);
    void Log(string message, LogLevel level);
  }
}
