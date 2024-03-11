using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

public class Problem1491Average
{
    public double Average(int[] salary)
    {
        int max = int.MinValue, min = int.MaxValue;
        double sum = 0;
        foreach (int s in salary)
        {
            max = Math.Max(max, s);
            min = Math.Min(min, s);
            sum += s;
        }

        return ((sum - min - max) / (double)(salary.Length - 2));

    }
}
