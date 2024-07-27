using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            string name;
            name = Console.ReadLine();
            if (name.Any())
            {
                Console.WriteLine($"Приветик {name}");
            }
            else
            {
                Console.WriteLine("Приветик никто ;-)");
            }
        }
    }
}
