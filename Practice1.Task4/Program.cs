using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            string phrase_1 = Console.ReadLine();

            string phrase_2 = Console.ReadLine();

            Console.WriteLine(phrase_1 + " " + phrase_2);
        }
    }
}
