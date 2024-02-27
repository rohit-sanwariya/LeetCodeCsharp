using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

public class Problem33SearchRotatedArray
{

    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (target == nums[mid])
            {
                return mid;
            }
            // in left sorted array left element would be less than or equal the middle one

            if (nums[left] <= nums[mid])
            {
                if (target > nums[mid] || target < nums[left])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            else
            {
                if (target < nums[mid] || target > nums[right])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }

            }

        }
        return -1;
    }
    }
