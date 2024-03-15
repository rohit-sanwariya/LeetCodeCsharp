namespace HashSetProblems;

public class Problem128LongestSubsequence
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        int longest = 0;
        foreach(int x in nums)
        {
            int len = 0;
            if(set.Contains(x - 1))
            {
                while (set.Contains(x + len))
                {
                    len++;
                }
                longest = Math.Max(longest, len);
            }
        }
        return longest;
    }
}
