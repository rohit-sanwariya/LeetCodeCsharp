using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

public class Problem724FindPivotIndex
{
    public int PivotIndex(int[] nums)
    {
        int ls = 0;
        int rs = 0;
    
        int total = nums.Sum();
        for (int i= 0;i < nums.Length;i++)
        {
          
            rs = total - nums[i] - ls;
            if(ls == rs)
            {
                return i;
            }
            else
            {
                ls += nums[i];
            }
            
        }
 
        return -1;
    }
}
