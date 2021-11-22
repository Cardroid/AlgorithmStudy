using System;
using System.Collections.Generic;
using System.Linq;

namespace BAEKJOON.Problems._2103_3w
{
    class _8979
    {
        static void Main()
        {
            string[] v = Console.ReadLine().Split(' ');
            int lineLength = int.Parse(v[0]);
            int resultCountry = int.Parse(v[1]);

            List<Country> countries = new List<Country>();
            for (int i = 0; i < lineLength; i++)
            {
                int[] countryInfo = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

                countries.Add(new Country(countryInfo[0], countryInfo[1], countryInfo[2], countryInfo[3]));
            }

            countries.Sort((c1, c2) => c1.CompareTo(c2));

            int[] resultInfo = new int[3];
            Country rC = countries.First(c => c.Index == resultCountry);
            resultInfo[0] = rC.Gold;
            resultInfo[1] = rC.Silver;
            resultInfo[2] = rC.Bronze;

            for (int i = 0; i < countries.Count; i++)
            {
                if (countries[i].Gold == resultInfo[0] && countries[i].Silver == resultInfo[1] && countries[i].Bronze == resultInfo[2])
                {
                    Console.WriteLine(i + 1);
                    break;
                }
            }
        }

        class Country : IComparable
        {
            public Country(int index, int gold, int silver, int bronze)
            {
                Index = index;
                Gold = gold;
                Silver = silver;
                Bronze = bronze;
            }

            public int Index { get; }
            public int Gold { get; }
            public int Silver { get; }
            public int Bronze { get; }

            public int CompareTo(object obj)
            {
                Country tempObj = obj as Country;

                if (this.Gold > tempObj.Gold)
                    return -1;
                else if (this.Gold < tempObj.Gold)
                    return 1;
                else
                {
                    if (this.Silver > tempObj.Silver)
                        return -1;
                    else if (this.Silver < tempObj.Silver)
                        return 1;
                    else
                    {
                        if (this.Bronze > tempObj.Bronze)
                            return -1;
                        else if (this.Bronze < tempObj.Bronze)
                            return 1;
                    }
                }
                return 0;
            }
        }
    }
}
