using System;

namespace ExchangeSort
{
    class Program
    {
        // Exchange Sort with Random Numbers

        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }

            var sortedArray = ExchangeSort(array);

            foreach (var num in sortedArray)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }

        private static int[] ExchangeSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int container = array[j];
                        array[j] = array[i];
                        array[i] = container;
                    }
                }
            }

            return array;
        }
    }
}
