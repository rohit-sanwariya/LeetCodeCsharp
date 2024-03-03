using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

public class Problem75SortColors
{
    public void swap(int[]nums,int i , int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;

    }
    public void SortColors(int[] nums)
    {
        int l = 0,i=0, r = nums.Length - 1;
        while(i<=r)
        {
            if (nums[i] == 0)
            {
                swap(nums,l, i);
                l++;
            }
            else if(nums[i]==2){
                swap(nums, i,r);
                i--;
                r--;
            }
            i++;
        }
        Console.WriteLine(string.Join(",",nums));
    }
}
