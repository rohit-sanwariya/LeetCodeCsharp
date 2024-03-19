using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

public class Problem881BoatsToSavePeople
{
    public int NumRescueBoats(int[] people, int limit)
    {
        int l = 0, r = people.Length - 1, count = 0;
        int  remain = 0;
        Array.Sort(people);
        while (l <= r)
        {
            remain  = limit - people[r];
            r--;
            count++;
            if(people[l] <= remain && l<=r)
            {
                l++;
             
            }
            

        }
        return count;
    }
}
