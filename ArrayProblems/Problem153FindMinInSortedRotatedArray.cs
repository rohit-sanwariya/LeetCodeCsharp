using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

public  class Problem153FindMinInSortedRotatedArray
{
    public int FindMin(int[] nums)
    {
        int l = 0,r = nums.Length-1,min = int.MaxValue;
        while (l <= r)
        {
            int m = (l + r) / 2;
            if (nums[l] <= nums[m])
            {
                if(min > nums[l])
                {
                    min = nums[l];
                }
                l = m + 1;
            }
            else
            {
                if (min > nums[m])
                {
                    min = nums[m];
                }
                r = m - 1;
            }
        }
        return min;
    }
}
