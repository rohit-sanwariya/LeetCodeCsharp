using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

public class Problem1446ConsecutiveMaxChar
{
    public int MaxPower(string s)
    {
        int max = 0, i = 0;
        while (i < s.Length)
        {
            char curr = s[i];
            int count = 0;
            while ( i < s.Length && curr == s[i] )
            {
                i++;
                count++;
                if (count > max)
                {
                    max = count;
                }
            }
        }
        return max;
    }
}
