using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems;

public class Problem791CustomSortString
{
    public string CustomSortString(string order, string s)
    {
        string res = "";
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (dict.TryGetValue(c, out int value))
            {
                dict[c] = value + 1;
            }
            else
            {
                dict.TryAdd(c, 1);
            }
        }
        foreach (char c in order)
        {
            if (dict.TryGetValue(c, out int value))
            {
                while (value > 0)
                {
                    res += c;
                    dict[c] = dict[c] - 1;
                    value--;
                }
            }
        }
        foreach (char c in s)
        {
            if (!order.Contains(c))
            {
                res += c;

            }
        }
        return res;
    }
}
