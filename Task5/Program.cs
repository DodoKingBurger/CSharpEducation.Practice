using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            float pi = (float)Math.PI;
            float circle_rad = 5.34f;

            Console.WriteLine($"Радиус заданного круга равен {pi* Math.Pow(circle_rad,2)}");
        }
    }
}
