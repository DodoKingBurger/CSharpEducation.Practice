using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Создайте перечисление(enum) для дней недели.Напишите программу, которая
            //выводит на экран дни недели по названиям
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            foreach (var days in Enum.GetValues(typeof(Week)))
            {
                Console.WriteLine($"{days}");
            }
        }            
        
         enum Week
        {
            Monday,
            Tuesday,
            Wednesday,   
            Thursday,  
            Friday,
            Saturday,   
            Sunday  
        }
    }
}

