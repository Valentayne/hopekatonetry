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

        static void FirstProblemP()
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

        static void SecondProblemP()
        {
            int[][] array;
            Console.WriteLine("Виберіть метод заповнення масиву: ");
            Console.WriteLine("1 - ввести в ручну;");
            Console.WriteLine("2 - заповнити рандомно;");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    array = ReadArrayFromConsole();

                    break;
                case 2:
                    Console.Write("Введіть розмірність масиву (рядки стовпці): ");
                    string[] size = Console.ReadLine().Split();
                    int rows = int.Parse(size[0]);
                    int cols = int.Parse(size[1]);
                    array = RandomFillArray(rows, cols);
                    break;
                default:
                    Console.WriteLine("Неправильний вибір.");
                    return;

            }
            Console.WriteLine("Масив:");
            PrintArray(array);

            Console.WriteLine("Введіть індекс рядка, який потрібно видалити: ");
            int k = int.Parse(Console.ReadLine());

            int[][] newArray = RemoveRow(array, k);
            Console.WriteLine("Масив після видалення:");
            PrintArray(newArray);
            Console.ReadKey();           
        }
        private static int[][] ReadArrayFromConsole()
        {
            Console.Write("Введіть розмірність масиву (рядки стовпці): ");
            string[] size = Console.ReadLine().Split();
            int rows = int.Parse(size[0]);
            int cols = int.Parse(size[1]);

            int[][] array = new int[rows][];
            Console.WriteLine($"Введіть {rows} рядків по {cols} елементів кожен:");
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
            return array;
        }

        private static void PrintArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[][] RemoveRow(int[][] array, int k)
        {
            int[][] newArray = new int[array.Length - 1][];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i != k)
                {
                    newArray[index] = array[i];
                    index++;
                }
            }
            return newArray;
        }
        private static int[][] RandomFillArray(int rows, int cols)
        {
            Random rnd = new Random();
            int[][] arr = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                arr[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    arr[i][j] = rnd.Next(11);
                }
            }
            return arr;
        }
    }
}
