using System;

namespace Algorithm_Insertion_Sort
{
    class Program
    {
        static void Swap(ref int element1, ref int element2)
        {
            var temp = element1;
            element1 = element2;
            element2 = temp;
        }

        static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j>0)&&(array[j-1]>key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }
            }
            return array;
        }

        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(100);
            }
            Console.WriteLine("-----Сортировка вставками-----");
            Console.WriteLine(string.Join(",", InsertionSort(array)));
        }
    }
}
