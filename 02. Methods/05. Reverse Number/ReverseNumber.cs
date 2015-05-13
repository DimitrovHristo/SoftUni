using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

class ReverseNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double inputNumber = double.Parse(Console.ReadLine());

        double reversed = GetReversedNumber(inputNumber);
        Console.WriteLine(reversed);
    }

    private static double GetReversedNumber(double inputNumber)
    {
        bool isNegative = inputNumber < 0;
        string input = string.Join("", inputNumber.ToString().TrimStart('-').Reverse());
        double number = double.Parse(input);
        return isNegative ? -number : number;
    }
}