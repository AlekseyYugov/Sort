using System;

namespace Algorithm_Cocktail_Sort
{
    class Program
    {
        static void Swap(ref int element1, ref int element2)
        {
            var temp = element1;
            element1 = element2;
            element2 = temp;
        }

        static int[] ShakerSort(int[]array)
        {
            for (int i = 0; i < array.Length/2; i++)
            {
                var swapflag = false;
                for (int j = i; j < array.Length-i-1; j++)
                {
                    if (array[j]>array[j+1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapflag = true;
                    }
                }
                for (int j = array.Length-i-2; j > i; j--)
                {
                    if (array[j-1]>array[j])
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        swapflag = true;
                    }
                }
                if (!swapflag)
                {
                    break;
                }
            }
            return array;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-----Шейкерная сортировка-----");
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(100);
            }
            Console.WriteLine(string.Join(",", ShakerSort(array)));

        }
    }
}
