namespace ArrayProblems;

public class Problem747LargestNumberAtleastTwiceOthers
{
    public int DominantIndex(int[] nums)
    {
        int max = -1;
        int smax = -1;
        int i = 0;
        
        for (int x = 0; x < nums.Length; x++)
        {
            if (nums[x] > max)
            {
                max = nums[x];
                smax = max;
                i = x;
            }
            else if (nums[x] > smax)
            {
                smax = nums[x];
               
            }
        }
        return max > 2 * smax ? i : -1;
    }

}
