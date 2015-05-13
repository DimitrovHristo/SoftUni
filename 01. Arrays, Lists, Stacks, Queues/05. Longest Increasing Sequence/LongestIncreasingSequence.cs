using System;
using System.Collections.Generic;
using System.Linq;

class LongestIncreasingSequence
{
    static void Main()
    {
        List<int> longest = new List<int>();
        List<int> counter = new List<int>();
        
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        for (int i = 0, j = 1; i < numbers.Length; i++, j++)
        {
            counter.Add(numbers[i]);

            if ((j < numbers.Length) && (numbers[i] <= numbers[j]))
            {
                continue;
            }

            else

            {
                if (counter.Count > longest.Count)
                {
                    longest.Clear();
                    longest.AddRange(counter);
                    Console.WriteLine(string.Join(" ", counter));
                    counter.Clear();
                }
                else
                {
                    Console.WriteLine(string.Join(" ", counter));
                    counter.Clear();
                }
            }
        }
        Console.WriteLine("Longest: " + string.Join(" ", longest));
    }
}
