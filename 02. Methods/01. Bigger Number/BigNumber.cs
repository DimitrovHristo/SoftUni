using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BigNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int biggerNum = GetMax(firstNumber, secondNumber);
        Console.WriteLine(biggerNum);
    }

    static int GetMax(int a, int b)
    {
        return Math.Max(a, b);
    }
}

