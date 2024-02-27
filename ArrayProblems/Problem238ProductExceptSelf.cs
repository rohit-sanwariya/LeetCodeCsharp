

namespace ArrayProblems;

public class Problem238ProductExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] prefix = new int[nums.Length];
        int[] postfix = new int[nums.Length];
        int start = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            prefix[i] = (i > 0 ? prefix[i - 1] : start) * nums[i];
        }
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            postfix[i] = (i + 1 <= nums.Length - 1 ? postfix[i + 1] : start) * nums[i];
        }
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = (i - 1 >= 0 ? prefix[i - 1] : start) * (i + 1 <= nums.Length - 1 ? postfix[i + 1] : start);
        }
        return nums;
    }
}
