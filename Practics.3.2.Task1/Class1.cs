﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics._3._2.Task1
{
 // 1.	Создай библиотеку классов, в которой будет класс "MathHelper"
 // с методами для выполнения основных математических операций(сложение, вычитание, умножение, деление).
 // Убедись, что библиотека компилируется без ошибок.
    public class MathHelper
    {
      public float Sum(float A,float B)
      {
        return A + B;
      }
      public float Subtract(float A,float B) { return A - B; }
      public float Divide(float A, float B)
      {
        if (B == 0)
        {
          throw new ArgumentException("Делить на нуль нельзя");
        }
        else 
          return A / B;
      }
      public float Multiplay(float A,float B)
      {
        return A * B;
      }
    }
}
