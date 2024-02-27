using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem34FirstLastPositionOfTarget
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int left = BinarySearch( nums, target,true);
            int right = BinarySearch(nums, target,false);
            return [left, right];
        }

        private int BinarySearch(int[] nums, int target, bool biasleft)
        {
            int i = -1;
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if(target == nums[mid])
                {
                    i = mid;
                    if (biasleft)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return i;
        }
    }
}
