using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте и реализуйте метод, который будет принимать число по ссылке(ref) и
            //менять его знак на противоположный. Метод должен принимать один аргумент и
            //не возвращать ничего.
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            Program mg = new Program();
            int Numb = -5;
            mg.ReversSign(ref Numb);
            Console.WriteLine(Numb);
        }
        public void ReversSign (ref int Numb)
        {
            Numb = Numb * -1;
        }
    }
}
