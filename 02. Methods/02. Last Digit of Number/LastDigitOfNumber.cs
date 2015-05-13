using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LastDigitOfNumber
{
    static void Main()
    {
    int number = int.Parse(Console.ReadLine());

    Console.WriteLine(GetLastDigitAsAWord(number));
    }

    static string GetLastDigitAsAWord(int a)
    {
        string number = "" + a;
        string digit;

        switch (number[number.Length - 1])
        {
            case '1':
                digit = "one";
                break;
            case '2':
                digit = "two";
                break;
            case '3':
                digit = "three";
                break;
            case '4':
                digit = "four";
                break;
            case '5':
                digit = "five";
                break;
            case '6':
                digit = "six";
                break;
            case '7':
                digit = "seven";
                break;
            case '8':
                digit = "eight";
                break;
            case '9':
                digit = "nine";
                break;
            default:
                digit = "zero";
                break;
        }
        return digit;
    }
}


