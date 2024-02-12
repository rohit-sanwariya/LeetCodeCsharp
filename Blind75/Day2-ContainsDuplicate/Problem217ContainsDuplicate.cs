 

namespace Blind75.Day2_ContainsDuplicate;

public class Problem217ContainsDuplicate
{

    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        return nums.Length == set.Count();
    }
}
