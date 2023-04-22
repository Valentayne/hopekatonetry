using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_лаб
{
    internal class Program
    {
        static int[] ResizeArray(int[] array, int length)
        {
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = array[i];
            }
            return arr;
        }
        static void MassivSort(ref int[] array)
        {
            int count = 0; int n = 0;
            int[] arr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) count++;
                else
                {
                    arr[n] = array[i]; n++;
                }
            }
            int length = array.Length - count;
            if (length == 0)
            {
                Console.WriteLine("Масив складається з непарних чисел");
            }
            array = ResizeArray(arr, length);
        }
        static void Outputmass(int[] massiv)
        {

            MassivSort(ref massiv);
            for (int i = 0; i < massiv.Length; i++)
            {
                Console.Write(massiv[i] + " ");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть розмiрнiсть масиву");
            int rows = int.Parse(Console.ReadLine());
            int[] array = new int[rows];
            string[] data = Console.ReadLine().Trim().Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(data[i]);
            }
            Outputmass(array);
            Console.ReadKey();
        }
    }
}