using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
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
            Console.WriteLine("Масив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Введіть індекс рядка, який потрібно видалити: ");
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
            Console.WriteLine("Масив після видалення:");
            for (int i = 0; i < newArray.Length; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(newArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }

    }
}
