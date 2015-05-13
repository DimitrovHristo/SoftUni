using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of integers seperated by one tab: ");
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(i,nums));
        }
    }
    static bool IsLargerThanNeighbours(int position, int[] digits)
    {
        if ((position == 0 && digits[position + 1] < digits[position]) ||
            (position == digits.Length - 1 && digits[position - 1] < digits[position]) ||
            ((position != 0 && position != digits.Length - 1) && 
            digits[position] > digits[position - 1] && digits[position] > digits[position + 1]))
        {
            return true;
        }
        return false;
    }
}
