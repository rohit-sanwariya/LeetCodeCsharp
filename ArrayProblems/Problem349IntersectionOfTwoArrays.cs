using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

public class Problem349IntersectionOfTwoArrays
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> set1 = new();
        HashSet<int> set2 = new();
        foreach (int el in nums1)
        {
            set1.Add(el);
        }
        foreach (int el in nums2)
        {
            set2.Add(el);
        }
        set1.IntersectWith(set2);
        return set1.ToArray();
    }
}
