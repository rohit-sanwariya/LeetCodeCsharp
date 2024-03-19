using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems;

public class Problem58LengthOfLastWord
{
    private int lastCount;

    public int LengthOfLastWord(string s)
    {
        int count = 0;
        foreach(var  c in s)
        {
           if(c == ' ')
            {
                lastCount = count != 0 ? count : lastCount;
                count = 0;
            }
            else
            {
                count++;
            }
        }
        return count == 0 ? lastCount : count;
    }
}
