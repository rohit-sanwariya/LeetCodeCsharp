using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

public class Problem179LargestNumber 
{
 
 

    public Problem179LargestNumber()
    {
        int[] nums = [3, 30, 34, 5, 9];
        //if (nums.All(x => x == 0)) return "0";
        string[] str = nums.Select(x => x.ToString()).ToArray();
        
        Array.Sort(str,new MySorter());
        Array.Reverse(str);

        Console.WriteLine(string.Join("",str));
    }

   
}


public class MySorter : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        string res1 = x + y;
        string res2 = y + x;
        if (double.TryParse(res1, out double result) && double.TryParse(res2, out double result2))
        {
            return result.CompareTo(result2);
        }
        return 0;
    }
}