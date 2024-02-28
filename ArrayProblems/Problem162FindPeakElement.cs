using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

public class Problem162FindPeakElement
{
    public int FindPeakElement(int[] nums)
    {
        int l = 0, r = nums.Length - 1,peak = -1;
        while (l <= r)
        {
            int m = (l) + ((r - l) / 2);
            if(m>0 && nums[m-1] > nums[m])
            {
               r = m - 1;
            }
            else if(m < nums.Length-1 && nums[m] > nums[m + 1])
            {
                l = m + 1;
            }
            else
            {
                peak = m;
                break;
            }
        }
        return peak;
        
    }
}
