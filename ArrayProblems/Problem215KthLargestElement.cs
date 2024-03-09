using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

internal class ReversePriority : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return y.CompareTo(x);
    }
}
public class Problem215KthLargestElement
{
    public int FindKthLargest(int[] nums, int k)
    {
        PriorityQueue<int, int> pq = new(new ReversePriority());
        foreach(int el in nums){
            pq.Enqueue(el, el);
        }

        while (pq.Count > 0)
        {
            int z = pq.Dequeue();
            if (k == 1) return z;
            k--;
        }
        return 0;
    }
}
