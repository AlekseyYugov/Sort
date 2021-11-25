using System;

namespace Algorithm_Shell_Sort
{
    class Program
    {
        static void Swap(ref int element1, ref int element2)
        {
            var temp = element1;
            element1 = element2;
            element2 = temp;
        }

        static int[] ShellSort(int[]array)
        {
            var d = array.Length / 2;
            while (d>0)
            {
                for (int i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j>=d) && (array[j-d]>array[j]))
                    {
                        Swap(ref array[j - d], ref array[j]);
                        j = j - d;
                    }
                }
                d = d / 2;
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
            Console.WriteLine("-----Сортировка Шелла-----");
            Console.WriteLine(string.Join(",", ShellSort(array)));
        }
    }
}
