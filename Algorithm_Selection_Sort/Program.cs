using System;

namespace Algorithm_Selection_Sort
{
    class Program
    {

        static int IndexOfMin(int[]array, int n)
        {
            int result = n;
            for (int i = n; i < array.Length; i++)
            {
                if (array[i]<array[result])
                {
                    result = i;
                }
            }
            return result;
        }
        static void Swap(ref int element1, ref int element2)
        {
            var temp = element1;
            element1 = element2;
            element2 = temp;
        }
        static int[] SelectionSort(int[]array, int currentIndex = 0)
        {
            if (currentIndex == array.Length)
            {
                return array;
            }
            var index = IndexOfMin(array, currentIndex);
            if (index!=currentIndex)
            {
                Swap(ref array[index], ref array[currentIndex]);
            }
            return SelectionSort(array, currentIndex + 1);
        }
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }
            Console.WriteLine("-----Сортировка выбором-----");
            Console.WriteLine(string.Join(",", SelectionSort(array)));
        }
    }
}
