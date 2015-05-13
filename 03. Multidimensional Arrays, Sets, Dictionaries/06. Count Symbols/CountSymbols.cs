using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountSymbols
{
    static void Main()
    {
        string inputText = Console.ReadLine();

        SortedDictionary<char, int> match = new SortedDictionary<char, int>();
        foreach (char symbol in inputText)
        {
            if (match.ContainsKey(symbol))
            {
                match[symbol]++;
            }
            else
            {
                match.Add(symbol, 1);
            }
        }

        foreach (KeyValuePair<char, int> pair in match)
        {
            Console.WriteLine("{0}: {1} time/s", pair.Key, pair.Value);
        }
    }
}