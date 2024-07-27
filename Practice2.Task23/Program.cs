using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу для вычисления високосного года.
            //  a.год, номер которого кратен 400, — високосный;
            //  остальные годы, номер которых кратен 100, — невисокосные
            //  остальные годы, номер которых кратен 4, — високосный;
            //  все остальные годы — невисокосные.
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            
            for(int Year = 0; Year <= 2024; Year++)
            {
                if (LeapYear(Year))
                {
                    Console.Write(Year + " ");
                }
            }

            bool LeapYear(int Year)
            {
                if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
