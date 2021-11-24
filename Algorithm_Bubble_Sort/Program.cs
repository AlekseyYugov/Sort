using System;

class Program
{
    static void Swap(ref int element1, ref int element2)
    {
        var temp = element1;
        element1 = element2;
        element2 = temp;
    }

    static int[] BubbleSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length-i; j++)
            {
                if (array[j]>array[j+1])
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
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
        Console.WriteLine("-----Сортировка пузырьком-----");
        Console.WriteLine(string.Join(",", BubbleSort(array)));
    }
}
