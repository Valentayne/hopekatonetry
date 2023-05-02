using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
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
