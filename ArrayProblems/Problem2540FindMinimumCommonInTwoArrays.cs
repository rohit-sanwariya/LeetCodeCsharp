using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

public class Problem2540FindMinimumCommonInTwoArrays
{
    public int GetCommon(int[] nums1, int[] nums2)
    {
        int l = 0,r=0;
        while(l<nums1.Length && r < nums2.Length)
        {
            if (nums1[l] < nums2[r])
            {
                l++;
            }
            else if (nums1[l] < nums2[r])
            {
                r++;
            }
            else
            {
                return nums1[l];
            }
        }
        return 0;

    }
}
