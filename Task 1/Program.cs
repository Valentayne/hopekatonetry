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
            Console.WriteLine("Введіть к-ть елементів масиву");
            int arrayLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть елементи масиву: ");
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
            Console.WriteLine("Оберіть формат заповнення: 1 - в ручну, 2 - рандомно");
            int choice = int.Parse(Console.ReadLine());

            int[] arr;

            switch (choice)
            {
                case 1:
                    arr = FillArray();
                    Console.WriteLine("Введіть елемент масиву з якого почнеться видалення: ");
                    int k = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введіть к-ть елементів, які хочете видалити: ");
                    int t = int.Parse(Console.ReadLine());

                    RemoveElementsFromArray(ref arr, k, t);

                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write(arr[i] + " ");
                    }
                    break;
                case 2:
                    Console.WriteLine("Введіть к-ть елементів масиву");
                    int arrayLength = int.Parse(Console.ReadLine());
                    arr = RandomFillArray(arrayLength);
                    Console.WriteLine("Введіть елемент масиву з якого начнеться видалення: ");
                    int start = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введіть к-ть елементів яку хочите видалити: ");
                    int count = int.Parse(Console.ReadLine());
                    RemoveElementsFromArray(ref arr, start, count);
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write(arr[i] + " ");
                    }
                    break;

                default:
                    Console.WriteLine("Невірний вибір");
                    return;
            }


            Console.ReadKey();
        }

        static void RemoveElementsFromArray(ref int[] arr, int k, int t)
        {
            int elementsToRemove = Math.Min(t, arr.Length - k); 

            if (elementsToRemove <= 0)
            {
                return;
            }

            int newLength = arr.Length - elementsToRemove;
            int[] newArr = new int[newLength];

            for (int i = 0; i < k; i++) 
            {
                newArr[i] = arr[i];
            }

            for (int i = k + elementsToRemove; i < arr.Length; i++) 
            {
                newArr[i - elementsToRemove] = arr[i];
            }

            arr = newArr; 
        }
        static int[] RandomFillArray(int length)
        {
            Random rnd = new Random();
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = rnd.Next(11);
            }
            Console.WriteLine("масив: ");
            Console.WriteLine(string.Join(" ", arr));
            return arr;
        }

    }
}
