using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_лаб_2_завд
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть розмiрнiсть  масиву");
            string[] data = Console.ReadLine().Split(' ');
            int rows = int.Parse(data[0]);
            int cols = int.Parse(data[1]);
            int[][] array = new int[rows][];
            int[][] last_mass = new int[rows / 2][];//4 
            int rowind = 1;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Розмiрнiсть першого рядка {rowind}: ");
                int count = int.Parse(Console.ReadLine());
                string[] values = Console.ReadLine().Trim().Split(' ');
                array[i] = new int[cols];
                for (int j = 0; j < count; j++)
                {
                    array[i][j] = int.Parse(values[j]);
                }
                for (int j = count; j < cols; j++)
                {
                    array[i][j] = 0;
                }
                rowind++;
            }
            rowind = 0;
            for (int i = 1; i < rows; i += 2)
            {
                last_mass[rowind] = array[i];
                rowind++;
            }
            Console.WriteLine();
            for (int i = 0; i < last_mass.GetLength(0); i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(last_mass[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}