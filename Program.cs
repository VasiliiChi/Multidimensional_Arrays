using System;

namespace Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            Console.WriteLine("Первый элемент массива равен: {0}", array[0, 0]);
            Console.WriteLine("Количество элементов в массиве равно: {0}", array.Length);
            Console.Write("Все элементы массива array: ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }


            Console.Write("\nКоличество строк: ");
            Console.Write(array.GetLength(0) + " ");

            Console.Write("\nКоличество колонок: ");
            Console.WriteLine(array.GetUpperBound(1) + 1 + " ");

            //Перебор массива по строкам
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
                    Console.Write(array[i, k] + " ");

                Console.WriteLine();
            }

            //Перебор массива по столбцам
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                    Console.Write(array[k, i] + " ");

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
