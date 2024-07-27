using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            //Создайте и реализуйте метод, который будет принимать массив на вход убирать
            //из него отрицательные числа и возвращать новый изменённый массив.Через
            //out параметр возвращать количество удалённых символов.
            Program mg = new Program();

            int[] Array = new int[] { -1,0,-2,1,-3,2,3 };
            Console.WriteLine("Оригинальный массив");
            for(int i = 0; i <= Array.Length - 1; i++)
            {
                Console.Write(Array[i] + " ");
            }
            Array = mg.CleanArray(Array, out int HowCleanNumb);
            Console.WriteLine($"\nКолличесвто удаленных символов: {HowCleanNumb}\nСам очищенный массив:");
            for(int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + " ");
            }
        }
        public int[] CleanArray(int[] Array, out int HowCleanNumb)
        {
            int PositNumb = 0;
            for (int i = 0; i <= Array.Length - 1; i++)
            {
                if (Array[i] > 0)
                    PositNumb++;
            }
            HowCleanNumb = Array.Length - 1 - PositNumb;
            int[] ArrayNew = new int[PositNumb+1];
            int j = 0;
            for (int i = 0; i <= Array.Length - 1; i++)
            {
                if (Array[i] >= 0)
                {
                    ArrayNew[j] = Array[i];
                    j++;
                }
            }
            return ArrayNew;
        }
    }
}
