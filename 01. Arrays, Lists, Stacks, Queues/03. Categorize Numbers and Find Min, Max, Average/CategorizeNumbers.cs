using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

class CategorizeNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        List<decimal> floatNumbers = new List<decimal>();
        List<decimal> roundNumbers = new List<decimal>();

        decimal[] arr = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

        for (int i = 0; i < arr.Length; i++)
        {
            if ((arr[i] % 1) == 0)
            {
                roundNumbers.Add(arr[i]);
            }
            else
            {
                floatNumbers.Add(arr[i]);
            }
        }
        Console.WriteLine("[" + string.Join(", ", floatNumbers) + "] -> min: {0}, max: {1}, sum: {2}, avg: {3:F2}",
                            floatNumbers.Min(), floatNumbers.Max(), floatNumbers.Sum(), floatNumbers.Average());

        Console.WriteLine("[" + string.Join(", ", roundNumbers) + "] -> min: {0}, max: {1}, sum: {2}, avg: {3:F2}",
                            roundNumbers.Min(), roundNumbers.Max(), (int)roundNumbers.Sum(), roundNumbers.Average());
    }
}