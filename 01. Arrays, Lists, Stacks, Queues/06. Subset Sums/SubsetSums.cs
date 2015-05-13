using System;
using System.Collections.Generic;
using System.Linq;

class SubsetSums
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        var numbers = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));

        int numOfSubsets = 1 << numbers.Count;
        bool found = false;

        for (int i = 0; i < numOfSubsets; i++)
        {
            int subLength = numbers.Count - 1;
            int counter = i;
            
            List<int> subset = new List<int>();

            while (counter > 0)
            {
                if ((counter & 1) == 1)
                {
                    subset.Add(numbers.ElementAt<int>(subLength));
                }
                counter >>= 1;
                subLength--;
            }
            if ((subset.Sum() == num) && (subset.Count != 0))
            {
                found = true;
                Console.WriteLine(string.Join(" + ", subset) + " = {0}", num);
            }
        }
        if (!found)
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}