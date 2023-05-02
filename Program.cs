using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exefaile
{

    internal class Program
    {
        static void RandomArray(ref int[] array, int x)
        {
            Random random = new Random();

            for (int i = 0; i < x; i++)
            {
                array[i] = random.Next(-100, 101);
            }
            Console.WriteLine("Заповнений масив");
            for (int i = 0; array.Length > i; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static void RandomMatrix(ref int[][] array, int rows, int cols)
        {
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                array[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    array[i][j] = random.Next(-100, 101);
                }
            }
            Console.WriteLine("Заповнений масив");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].GetLength(0); j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void SecondProblemV()
        {
            int rowind = 1;
            Console.WriteLine("Введiть розмiрнiсть  масиву, в рядок");
            string[] data = Console.ReadLine().Split(' ');
            int rows = int.Parse(data[0]);
            int cols = int.Parse(data[1]);
            int[][] array = new int[rows][];
            Console.WriteLine("Оберiть метод заповнення масиву 1 рандом, 2 вручну");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1: RandomMatrix(ref array, rows, cols); break;
                case 2:
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
                    break;
            }

            int[][] last_mass = new int[rows / 2][];//4 
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

            Console.WriteLine();
        }
        static void FirstProblemV()
        {
            Console.WriteLine("Введiть розмiрнiсть масиву");
            int rows = int.Parse(Console.ReadLine());
            int[] array = new int[rows];
            Console.WriteLine("Оберiть метод заповнення масиву 1 рандом, 2 вручну");

            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    RandomArray(ref array, rows);
                    break;

                case 2:
                    string[] data = Console.ReadLine().Trim().Split(' ');
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = Convert.ToInt32(data[i]);
                    };
                    break;
            }
            Outputmass(array);

        }

        static void Main(string[] args)
        {
        axmed:
            Console.WriteLine("\tВиберiть яке завдання хочете виконати");
            Console.Write("1 буде виконуватись завдання з одновимiрним масивом 2 завдання з зубчастим: ");

            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("Оберiть виконувача 1) Pavel , 2) Valentyn");
                Netypu:
                    int y = int.Parse(Console.ReadLine());
                    switch (y)
                    {
                        case 1:
                            FirstProblemP();
                            break;
                        case 2:
                            FirstProblemV();

                            break;
                        default:
                            Console.WriteLine("Iншого виконувача не iснує, оберiть одного iз наявних");
                            goto Netypu;
                    }
                    Console.Write("нажмiть (1) якщо хочете повторити цю задачу i любу iншу якщо хочете пiти далi: ");
                    int n = int.Parse(Console.ReadLine());
                    if (n == 1)
                    {
                        if (y == 1)
                        {
                            FirstProblemP();
                        }
                        else if (y == 2)
                        {
                            FirstProblemV();
                        }


                    }
                    break;




                case 2:
                    Console.WriteLine("Оберiть виконувача 1) Pavel , 2) Valentyn");
                    int zz = int.Parse(Console.ReadLine());
                nameof:
                    switch (zz)
                    {
                        case 1:
                            SecondProblemP();
                            break;
                        case 2:
                            SecondProblemV();
                            break;
                        default:
                            Console.WriteLine("Iншого виконувача не iснує, оберiть одного iз наявних");
                            goto nameof;
                    }
                    Console.Write("нажмiть (1) якщо хочете повторити цю задачу i любу iншу якщо хочете пiти далi: ");
                    int n1 = int.Parse(Console.ReadLine());
                    if (n1 == 1)
                    {
                        if (zz == 1)
                        {
                            SecondProblemP();
                        }
                        else if (zz == 2)
                        {
                            SecondProblemV();
                        }

                    }
                    break;
                default:
                    Console.WriteLine("Було введено значення яке не вiдповiдає умовi, повторiть спробу");
                    goto axmed;
            }
            Console.WriteLine();
            Console.WriteLine("Хочите переглянути iншi завдання нажмiть 1 в iншому випадку програма зупинить свою роботу");
            x = int.Parse(Console.ReadLine());
            if (x == 1)
                goto axmed;

        }

        static int[] FillArray()
        {
            Console.WriteLine("Введiть к-ть елементiв масиву");
            int arrayLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Введiть елементи масиву, роздiленi пробiлами: ");
            string input = Console.ReadLine();
            string[] strArr = input.Split();

            int[] arr = new int[strArr.Length];

            for (int i = 0; i < arrayLength; i++)
            {
                arr[i] = int.Parse(strArr[i]);
            }
            return arr;
        }

        static void FirstProblemP()
        {
            int[] arr = FillArray();
            Console.Write("Введiть елемент масиву з якого почнеться видалення: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введiть к-ть елементiв яку хочите видалити: ");
            int t = int.Parse(Console.ReadLine());

            RemoveElementsFromArray(ref arr, k, t);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
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

        static void SecondProblemP()
        {
            Console.Write("Введiть розмiрнiсть масиву (рядки стовпцi): ");
            string[] size = Console.ReadLine().Split();
            int rows = int.Parse(size[0]);
            int cols = int.Parse(size[1]);

            int[][] array = new int[rows][];

            Console.WriteLine($"Введiть {rows} рядкiв по {cols} елементiв кожен:");
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Рядок {i + 1}: ");
                string[] values = Console.ReadLine().Split();

                array[i] = new int[cols];

                for (int j = 0; j < cols; j++)
                {
                    if (j < values.Length)
                    {
                        array[i][j] = int.Parse(values[j]);
                    }
                    else
                    {
                        array[i][j] = 0;
                    }
                }
            }
            Console.WriteLine("Масив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Введiть iндекс рядка, який потрiбно видалити: ");
            int k = int.Parse(Console.ReadLine());

            int[][] newArray = new int[rows - 1][];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                if (i != k)
                {
                    newArray[index] = new int[cols];

                    for (int j = 0; j < cols; j++)
                    {
                        newArray[index][j] = array[i][j];
                    }

                    index++;
                }
            }
            Console.WriteLine("Масив пiсля видалення:");
            for (int i = 0; i < newArray.Length; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(newArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
