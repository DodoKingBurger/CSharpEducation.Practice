using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите метод, который создаёт двумерный массив(не зубчатый).Размеры
            //массива передавайте через аргументы метода.Также напишите отдельный
            //метод для вывода двумерного массива в виде матрицы на экран консоли.
            //Массив заполните случайными числами.
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            Program mg = new Program();
            mg.PrintMatrix(mg.CraeateArray(3));

        }
        public int[,] CraeateArray(int Length)
        {
            int[,] ArrayMatrix = new int[Length, Length];
            Random rnd = new Random();
            for(int i = 0; i < Length; i++)
            {
                for(int j = 0; j < Length; j++)
                {
                    ArrayMatrix[i, j] = rnd.Next(1, 100);
                }
            }
            return ArrayMatrix;
        }
        public void PrintMatrix(int[,] ArrayMatrix)
        {
            for (int i = 0;i < ArrayMatrix.GetLength(0); i++)
            {
                for( int j = 0;j < ArrayMatrix.GetLength(0); j++)
                {
                    Console.Write(ArrayMatrix[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
