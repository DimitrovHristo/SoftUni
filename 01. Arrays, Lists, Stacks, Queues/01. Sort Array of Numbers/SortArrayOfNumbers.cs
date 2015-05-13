using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArrayOfNumbers
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Array.Sort(arr);

        string sortedArr = string.Join(" ", arr);
        Console.WriteLine(sortedArr);
    }
}

