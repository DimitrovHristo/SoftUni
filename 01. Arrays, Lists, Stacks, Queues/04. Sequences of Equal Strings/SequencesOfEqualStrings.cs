using System;
using System.Collections.Generic;

class SequencesOfEqualStrings
{
    static void Main()
    {
        List<string> arrString = new List<string>(Console.ReadLine().Split());


        for (int i = 0; i < arrString.Count; i++)
        {
            if (i < arrString.Count - 1)
            {
                for (int j = i + 1; j < arrString.Count; j++)
                {
                    if (arrString[i] == arrString[j])
                    {
                        Console.Write(arrString[j] + " ");
                        arrString.RemoveAt(j);
                        j--;
                    }
                }
            }
            Console.Write(arrString[i]);
            Console.WriteLine();
        }
    }
}