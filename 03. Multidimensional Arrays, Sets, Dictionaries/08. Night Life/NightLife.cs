using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NightLife
{
    static void Main()
    {
        Dictionary<string, SortedDictionary<string, SortedSet<string>>> nightLifeDict =
        new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

        string[] eventTokens;
        string city = String.Empty;
        string venue = String.Empty;
        string performer = String.Empty;
        string party = Console.ReadLine();

        while (party != "END")
        {
            eventTokens = party.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            city = eventTokens[0];
            venue = eventTokens[1];
            performer = eventTokens[2];

            if (!nightLifeDict.ContainsKey(city))
            {
                nightLifeDict[city] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!nightLifeDict[city].ContainsKey(venue))
            {
                nightLifeDict[city][venue] = new SortedSet<string>();
            }
            nightLifeDict[city][venue].Add(performer);

            party = Console.ReadLine();
        }

        foreach (var cityPair in nightLifeDict)
        {
            Console.WriteLine(cityPair.Key);
            foreach (var venuePair in cityPair.Value)
            {
                Console.WriteLine("->{0}: {1}", venuePair.Key, String.Join(", ", venuePair.Value));
            }
        }
    }
}
