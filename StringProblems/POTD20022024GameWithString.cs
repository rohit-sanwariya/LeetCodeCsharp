using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems;

public class POTD20022024GameWithString
{
    public int minValue(string s, int k)
    {
        //Your code here
        Dictionary<char, int> dict = new();
        PriorityQueue<char, int> pq = new PriorityQueue<char, int>();
        int sum = 0;
        
        foreach (char c in s)
        {
            if (dict.TryGetValue(c, out int value))
            {
                dict[c] = dict[c] + 1;
            }
            else
            {
                dict[c] = 1;
            }
        }

        foreach(var it  in dict)
        {
            pq.Enqueue(it.Key,it.Value);
        }

        foreach (var it in dict)
        {
            sum += it.Value * it.Value;
        }
 
        return sum;
    }
}
