using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

public class Problem35SearchInsertPosition
{
    public int SearchInsert(int[] nums, int target)
    {
        int l = 0, r = nums.Length - 1, pos = -1;
        int min = int.MaxValue;
        int i = -1;
        int el = int.MaxValue;
        while (l <= r)
        {
            int m = (l) + ((r - l) / 2);
            if(Math.Abs(target - nums[m]) < min)
            {
                min = Math.Abs(target - nums[m]);
                 i = m;
                el = nums[m];
            }
            if (nums[m] == target)
            {
                pos = m;
                break;
            }
            else if (target > nums[m]) {
                l = m + 1;
            }
            else
            {
                r = m - 1;
            }
        }
        return pos == -1 ? (target > el  ? i + 1 : i) : pos;
    }
}
