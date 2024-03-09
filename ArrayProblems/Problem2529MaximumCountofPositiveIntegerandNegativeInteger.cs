using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

public class Problem2529MaximumCountofPositiveIntegerandNegativeInteger
{
    public int MaximumCount(int[] nums)
    {

        return Math.Max(LastNegative(nums) + 1, nums.Length - FirstPositive(nums));
    }

    public int FirstPositive(int[] nums)
    {
        int l = 0, r = nums.Length - 1, times = nums.Length;


        while (l <= r)
        {
            int m = (l + r) / 2;
            if (nums[m] > 0)
            {

                times = m;
                r = m - 1;

            }
            else
            {
                l = m + 1;
            }
        }


        return times;
    }

    public int LastNegative(int[] nums)
    {
        int l = 0, r = nums.Length - 1, times = -1;


        while (l <= r)
        {
            int m = (l + r) / 2;
            if (nums[m] < 0)
            {

                times = m;
                l = m + 1;

            }
            else
            {
                r = m - 1;
            }
        }


        return times;
    }
}
