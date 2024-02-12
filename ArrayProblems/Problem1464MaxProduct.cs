 

namespace ArrayProblems;

public class Problem1464MaxProduct
{
    public int MaxProduct(int[] nums)
    {
        if (nums.Length == 2)
        {
            return (nums[0] - 1) * (nums[1] - 1);
        }
        else
        {
            int max = -1;
            int smax = -1;
            foreach (int curr in nums)
            {
                if (curr > max)
                {
                    smax = max;
                    max = curr;

                }
                else if (curr > smax)
                {
                    smax = curr;
                }
            }
            return (max - 1) * (smax - 1);
        }
    }
}
