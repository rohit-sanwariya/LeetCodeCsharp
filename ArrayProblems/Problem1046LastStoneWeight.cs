using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;
 
public class Problem1046LastStoneWeight
{
    public int LastStoneWeight(int[] stones)
    {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        foreach(int stone in stones)
        {
            pq.Enqueue(stone, -stone);
        }
        while (pq.Count > 1)
        {
            int stone1 = pq.Dequeue();
            int stone2 = pq.Dequeue();
            if(stone1 != stone2)
            {
                pq.Enqueue(stone1 > stone2 ? stone1 - stone2 : stone2 - stone1, 0-stone1 > stone2 ? stone1 - stone2 : stone2 - stone1);

            }
        }
        return pq.Count >= 1 ? pq.Peek() : 0; 
}
}
