using System;
using System.Linq;

class SortArrayUsingSelectionSort
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        while (true)
        {
            bool check = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int counter = 0;
                if (arr[i] > arr[i + 1])
                {
                    counter = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = counter;
                    check = true;
                }
            }
            if (!check)
            {
                break;
            }
        }
        Console.WriteLine(string.Join(",", arr));
    }
}

