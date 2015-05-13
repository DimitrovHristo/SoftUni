using System;
using System.Collections.Generic;

class SequencesOfEqualStrings
{
    static void Main()
    {
        List<string> arrayString = new List<string>(Console.ReadLine().Split());

        for (int i = 0; i < arrayString.Count; i++)
        {
            if (i < arrayString.Count - 1)
            {
                for (int j = i + 1; j < arrayString.Count; j++)
                {
                    if (arrayString[i] == arrayString[j])
                    {
                        Console.Write(arrayString[j] + " ");
                        arrayString.RemoveAt(j);
                        j--;
                    }
                }
            }
            Console.Write(arrString[i]);
            Console.WriteLine();
        }
    }
}