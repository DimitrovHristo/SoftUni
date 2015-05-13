using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FirstLargerThanNeighbours
{
        private static void Main()
    {
        int[] sequenceOne = {1, 3, 4, 5, 1, 0, 5};
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceThree = { 1, 1, 1 };

        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
    }

    static int GetIndexOfFirstElementLargerThanNeighbours(int[] digits)
    {
        int result = -1;

        if (digits.Length > 1)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                if (i == 0)
                {
                    if (digits[i] > digits[i + 1])
                    {
                        result = i;
                        goto End;
                    }
                }
                else if (i == digits.Length - 1)
                {
                    if (digits[i] > digits[i - 1])
                    {
                        result = i;
                        goto End;
                    }
                }
                else
                {
                    if ((digits[i] > digits[i + 1]) && (digits[i] > digits[i - 1]))
                    {
                        result = i;
                        goto End;
                    }
                }
            }
        }
        End:
        return result;
    }
}