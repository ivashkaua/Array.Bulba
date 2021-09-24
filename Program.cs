using System;

namespace Bulba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: \t");
            int ArrNumber = int.Parse(Console.ReadLine());
            int[] array = new int[ArrNumber];

            for (int l = 0; l < ArrNumber; l++)
            {
                Console.Write($"\nВведите число с индексом {l} \t");
                array[l] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Ваш массив выглядит следующим образом: ");
            for (int i = 0; i < ArrNumber; i++)
            {
                Console.Write(array[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("\nПосле сортировки Ваш массив выглядит следующим образом: ");

            for (int i = 0; i < array.Length; i++)
            {
                for (int n = 0; n < array.Length - 1; n++)
                {
                    if (array[n] > array[n + 1])
                    {
                        int temp = array[n + 1];
                        array[n + 1] = array[n];
                        array[n] = temp;
                    }
                }
            }
            
            for (int m = 0; m < ArrNumber; m++)
            {
                Console.Write(array[m] + "\t");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
