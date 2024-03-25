using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

public class Problem442FindAllDuplicatesInAnArray
{
    public IList<int> FindDuplicates(int[] nums)
    {
        IList<int> res = [];
        for (int i= 0;i < nums.Length;i++)
        {
            int current = Math.Abs(nums[i]);
            if (nums[current-1] < 0)
            {
                res.Add(current);
            }
            else
            {
                nums[current - 1] = -nums[current - 1];
            }
        }
        return res;
    }
}
