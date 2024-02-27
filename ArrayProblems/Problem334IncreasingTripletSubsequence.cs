using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

public class Problem334IncreasingTripletSubsequence
{
    public bool IncreasingTriplet(int[] nums)
    {
        int first = int.MaxValue, second = int.MaxValue, third = int.MaxValue;

        foreach (int x in nums)
        {
            if (x <= first)
            {
                first = x;

            }
            else if (x <= second)
            {
                second = x;
            }
            else if (x <= third)
            {
                third = x;
                return true;
            }
        }

        return false;
    }
}
