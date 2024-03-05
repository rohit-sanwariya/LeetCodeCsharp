using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

public class Problem2089FindTargetIndicesAfterSortingArray
{
    public IList<int> TargetIndices(int[] nums, int target)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        List<int> indices = new List<int>();
        foreach(int num in nums)
        {
            if (num <= target)
            {
                if(dict.TryGetValue(num,out int value))
                {
                    dict[num] += 1;
                }
                else
                {
                    dict.TryAdd(num, 1);
                }
            }
        }
        int sum = 0;
        foreach(var it  in dict)
        {
            if(it.Key != target)
            {
                sum += it.Value;
            }
        }
        dict.TryGetValue(target, out int times);
        for(int i = 0; i < times; i++)
        {
            indices.Add(sum + i);
        }
        return indices;
    }
}
