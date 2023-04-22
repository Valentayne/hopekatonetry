using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static int[] FillArray()
        {
            Console.WriteLine("Ввеліть к-ть елементі масиву");
            int arrayLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть елементи масиву, розділені пробілами: ");
            string input = Console.ReadLine(); 
            string[] strArr = input.Split(); 

            int[] arr = new int[strArr.Length];

            for (int i = 0; i < arrayLength; i++)
            {
                arr[i] = int.Parse(strArr[i]); 
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = FillArray();
            Console.Write("Введіть елемент масиву з якого начнеться видалення: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введіть к-ть елементів яку хочите видалити: ");
            int t = int.Parse(Console.ReadLine());

            RemoveElementsFromArray(ref arr, k, t);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }
        static void RemoveElementsFromArray(ref int[] arr, int k, int t)
        {
            int elementsToRemove = Math.Min(t, arr.Length - k); // це к-ть ел дня видалення

            if (elementsToRemove <= 0) // той випадок якщо елементів нема
            {
                return;
            }

            int newLength = arr.Length - elementsToRemove; // нова довжина масиву
            int[] newArr = new int[newLength];

            for (int i = 0; i < k; i++) // переношу чистину масиву
            {
                newArr[i] = arr[i];
            }

            for (int i = k + elementsToRemove; i < arr.Length; i++) 
            {
                newArr[i - elementsToRemove] = arr[i]; // копія масиву вже після видалення
            }

            arr = newArr; 
        }
    }
}
