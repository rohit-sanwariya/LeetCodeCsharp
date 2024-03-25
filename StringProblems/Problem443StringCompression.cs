using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems;

public class Problem443StringCompression
{
    public int Compress(char[] chars)
    {
        int count = 0, i = 0, j = 0;
        string ans = "";
        if (chars.Length <= 2)
        {
            return chars.Length;
        }

        while (i < chars.Length && j < chars.Length)
        {
            char curr = chars[i];
            char next = chars[j];
           
            if(curr == next)
            {
                count++;               
                j++;
            }
            else
            {
                ans += curr;
                if (count > 1)
                {
                    ans += count;
                }
                count = 1;
                i = j;
                j++;
            }
        }
        ans += chars[i];
        if (count > 1)
        {
            
            ans += count;
        }
        for(int k = 0; k < ans.Length; k++)
        {
            chars[k] = ans[k];
        }
        return ans.Length;
    }
}
