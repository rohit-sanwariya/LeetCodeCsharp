using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

public class Problem1394LuckyNumber
{
    public int FindLucky(int[] arr)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int x in arr)
        {
            if (dict.TryGetValue(x, out int value))
            {
                dict[x] = dict[x] + 1;

            }
            else
            {
                dict.TryAdd(x, 1);
            }
        }
        int lucky = -1;
        foreach (var it in dict)
        {
            if (it.Key == it.Value)
            {
                lucky = it.Key;
            }
        }
        return lucky;
    }
}
