 

namespace ArrayProblems
{
    public class Problem1464MaxProduct
    {
        public int MaxProduct(int[] nums)
        {
            if (nums.Length == 2)
            {
                return nums[0] - 1 * nums[1] - 1;
            }
            Array.Sort(nums, new Comparison<int>((a, b) => b.CompareTo(a)));
            return (nums[0] - 1) * (nums[1] - 1);
        }
    }
}
